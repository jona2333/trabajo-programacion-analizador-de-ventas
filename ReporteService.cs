using AnalizadorVentasRopa.Models;
using AnalizadorVentasRopa.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AnalizadorVentasRopa.Services
{
    public class ReporteService
    {
        public async Task<string> ExportarVentasAsync(List<Venta> ventas, string rutaDestino)
        {
            await ConcurrencyUtils.ReporteSemaphore.WaitAsync();

            try
            {
                bool esExcel = rutaDestino.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase);

                if (esExcel)
                {

                    rutaDestino = Path.ChangeExtension(rutaDestino, ".csv");
                }

                using (var writer = new StreamWriter(rutaDestino))
                {
                    await writer.WriteLineAsync("Fecha,Producto,Cantidad,Precio,Categoria,Total");

                    foreach (var venta in ventas)
                    {
                        decimal total = venta.Cantidad * venta.Precio;
                        await writer.WriteLineAsync($"{venta.Fecha:yyyy-MM-dd},{venta.Producto},{venta.Cantidad}," +
                            $"{venta.Precio},{venta.Categoria},{total}");
                    }
                }

                return rutaDestino;
            }
            finally
            {
                ConcurrencyUtils.ReporteSemaphore.Release();
            }
        }
        public async Task<string> ObtenerAnalisisIAAsync(List<Venta> ventas, string apiKey)
        {
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // 1. Prepara los datos de ventas en texto resumido para enviar a la IA
                var resumenVentas = new StringBuilder();
                resumenVentas.AppendLine("Resumen de ventas:");
                foreach (var v in ventas.Take(50)) // Limita para no saturar la API
                {
                    resumenVentas.AppendLine($"{v.Fecha:yyyy-MM-dd}, Producto: {v.Producto}, Cantidad: {v.Cantidad}, Precio: {v.Precio}, Categoria: {v.Categoria}");
                }
                if (ventas.Count > 50)
                    resumenVentas.AppendLine($"...y {ventas.Count - 50} ventas más.");

                // 2. Prepara el mensaje para la IA
                var prompt = "Analiza detalladamente el siguiente resumen de ventas de ropa. Realiza un diagnóstico profesional y objetivo sobre el desempeño del negocio, identificando con precisión las tendencias más importantes, los principales puntos fuertes y las debilidades críticas. " +
                    "\r\n\r\nLuego, entrega exactamente 3 recomendaciones prácticas y altamente efectivas para incrementar las ventas. Cada recomendación debe ser:\r\n-" +
                    " Específica y directamente aplicable al contexto de un pequeño negocio de ropa.\r\n- Explicada con claridad, incluyendo el motivo por el cual será efectiva.\r\n-" +
                    " Orientada a obtener resultados medibles y sostenibles en el corto y mediano plazo." +
                    "\r\n\r\nAsegúrate de que los consejos sean innovadores, realistas y basados en buenas prácticas comprobadas del sector." +
                    " Evita generalidades y prioriza acciones concretas que puedan marcar una diferencia real en las ventas. Usa un lenguaje claro, directo y profesional..\n\n" + resumenVentas.ToString();
                //deepseek-chat
                var requestBody = new
                {
                    model = "claude-3-5-sonnet-latest",
                    messages = new[]
                    {
                new {
                    role = "user",
                    content = new[] {
                        new { type = "text", text = prompt }
                    }
                }
            }
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

                var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Post, "https://openapi.monica.im/v1/chat/completions");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
                request.Content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Error al consultar la IA: " + response.StatusCode);

                var responseContent = await response.Content.ReadAsStringAsync();

                // Extrae solo la respuesta de la IA (ajusta según el formato real de respuesta)
                dynamic parsed = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);
                string resultadoIA = parsed.choices[0].message.content.ToString();

                return resultadoIA;
            }
        }
        public async Task<string> ExportarVentasPDFAsync(List<Venta> ventas, string rutaDestino, string analisisIA = "")
        {
            await ConcurrencyUtils.ReporteSemaphore.WaitAsync();
            try
            {
                using (FileStream fs = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document(PageSize.A4, 25, 25, 30, 30))
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();

                    // Título
                    var titulo = new Paragraph("Reporte de Ventas de Ropa")
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 15f
                    };
                    doc.Add(titulo);

                    // Tabla de ventas
                    PdfPTable table = new PdfPTable(6);
                    table.WidthPercentage = 100;
                    table.AddCell("Fecha");
                    table.AddCell("Producto");
                    table.AddCell("Cantidad");
                    table.AddCell("Precio");
                    table.AddCell("Categoria");
                    table.AddCell("Total");

                    foreach (var venta in ventas)
                    {
                        table.AddCell(venta.Fecha.ToString("yyyy-MM-dd"));
                        table.AddCell(venta.Producto);
                        table.AddCell(venta.Cantidad.ToString());
                        table.AddCell(venta.Precio.ToString("C"));
                        table.AddCell(venta.Categoria);
                        table.AddCell((venta.Cantidad * venta.Precio).ToString("C"));
                    }

                    doc.Add(table);

                    // Espacio
                    doc.Add(new Paragraph("\n"));

                    // Análisis de la IA (si existe)
                    if (!string.IsNullOrWhiteSpace(analisisIA))
                    {
                        var analisisTitulo = new Paragraph("Análisis de la IA y Tips para Mejorar", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14))
                        {
                            SpacingBefore = 10f,
                            SpacingAfter = 5f
                        };
                        doc.Add(analisisTitulo);

                        var analisis = new Paragraph(analisisIA, FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        doc.Add(analisis);
                    }

                    doc.Close();
                }
                return rutaDestino;
            }
            finally
            {
                ConcurrencyUtils.ReporteSemaphore.Release();
            }
        }
    }
}
