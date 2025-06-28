using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalizadorVentasRopa.Models;
using AnalizadorVentasRopa.Services;
using AnalizadorVentasRopa.Utils;
using MetroFramework.Forms;
namespace AnalizadorVentasRopa
{
    public partial class Form1 : MetroForm
    {
        private ExcelService excelService = new ExcelService();
        private AnalisisService analisisService = new AnalisisService();
        private GraficoService graficoService = new GraficoService();
        private int ventaActual = 0;
        private List<Venta> ventas = new List<Venta>();

        public Form1()
        {
            InitializeComponent();

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            metroStyleManager.Owner = this;

            listBoxLogs.Columns.Add("Fecha/Hora", 150);
            listBoxLogs.Columns.Add("Evento", 250);
            listBoxLogs.Columns.Add("Descripción", 1040);
            

            AgregarLogCompleto("Aplicación iniciada", "El analizador de ventas se ha iniciado correctamente");

            metroToggle1.CheckedChanged += (s, ev) => {
                if (metroToggle1.Checked)
                {
                    metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    AgregarLogCompleto("Cambio de tema", "Se ha activado el tema oscuro");
                }
                else
                {
                    metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    AgregarLogCompleto("Cambio de tema", "Se ha activado el tema claro");
                }
                Refresh();
            };

            btnExportar.Click += (s, ev) => {
                AgregarLogCompleto("Exportación", "Se ha iniciado el proceso de exportación de datos");
                MessageBox.Show("Función de exportación en desarrollo", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnLimpiar.Click += (s, ev) => {
                LimpiarFiltros();
                AgregarLogCompleto("Filtros", "Se han limpiado todos los filtros");
            };
        }

        private void AgregarLog(string mensaje)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => AgregarLogCompleto("Proceso", mensaje)));
            }
            else
            {
                AgregarLogCompleto("Proceso", mensaje);
            }
        }

        private void AgregarLogCompleto(string evento, string descripcion)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => {
                        try
                        {
                            ListViewItem item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            item.SubItems.Add(evento);
                            item.SubItems.Add(descripcion);
                            listBoxLogs.Items.Add(item);
                            listBoxLogs.Items[listBoxLogs.Items.Count - 1].EnsureVisible();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al agregar log: " + ex.Message, "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                }
                else
                {
                    ListViewItem item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(evento);
                    item.SubItems.Add(descripcion);
                    listBoxLogs.Items.Add(item);
                    listBoxLogs.Items[listBoxLogs.Items.Count - 1].EnsureVisible();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar log: {ex.Message}");
            }
        }


        private void LimpiarFiltros()
        {
            dtpInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFin.Value = DateTime.Now;
            cbProducto.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
        }

        private async void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            string rutaArchivo = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Selecciona el archivo de ventas";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                }
                else
                {
                    AgregarLog("Carga cancelada por el usuario, Jona.");
                    return;
                }
            }

            try
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;

                var progressTimer = new System.Windows.Forms.Timer();
                progressTimer.Interval = 100;
                int progressValue = 0;
                progressTimer.Tick += (s, ev) => {
                    progressValue += 2;
                    if (progressValue <= 95) 
                        progressBar1.Value = progressValue;
                    else
                        progressTimer.Stop();
                };
                progressTimer.Start();

                await Task.Run(() => {
                    try
                    {
                        ventas = excelService.LeerVentasDesdeExcel(rutaArchivo);
                        AgregarLog("Lectura de Excel terminada.");

                        analisisService.Analizar(ventas);
                        AgregarLog("Análisis de ventas terminado.");
                    }
                    catch (Exception ex)
                    {
                        AgregarLog("Error procesando datos: " + ex.Message);
                    }
                });

                progressTimer.Stop();

                ActualizarInterfazCompleta();

                progressBar1.Value = 100;
                await Task.Delay(1000); 
                progressBar1.Visible = false;

                AgregarLog("¡Todos los procesos han terminado!");
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                AgregarLog("Error general: " + ex.Message);
                MessageBox.Show("Error al cargar archivo: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? fechaInicio = dtpInicio.Value.Date;
                DateTime? fechaFin = dtpFin.Value.Date;
                string producto = cbProducto.SelectedItem?.ToString();
                string categoria = cbCategoria.SelectedItem?.ToString();

                progressBar1.Value = 0;
                progressBar1.Visible = true;

                var progressTimer = new System.Windows.Forms.Timer();
                progressTimer.Interval = 50;
                int progressValue = 0;
                progressTimer.Tick += (s, ev) => {
                    progressValue += 5;
                    if (progressValue <= 95)
                        progressBar1.Value = progressValue;
                    else
                        progressTimer.Stop();
                };
                progressTimer.Start();

                AgregarLogCompleto("Filtros", $"Aplicando filtros: Fecha inicio={fechaInicio}, " +
                    $"Fecha fin={fechaFin}, Producto={producto ?? "Todos"}, Categoría={categoria ?? "Todas"}");

                await Task.Run(() => {
                    try
                    {
                        analisisService.Analizar(ventas, fechaInicio, fechaFin, producto, categoria);
                        AgregarLog("Filtrado de datos completado.");
                    }
                    catch (Exception ex)
                    {
                        AgregarLog("Error durante el filtrado: " + ex.Message);
                        throw; 
                    }
                });

                progressTimer.Stop();
                ActualizarInterfazCompleta();

                progressBar1.Value = 100;
                await Task.Delay(1000);
                progressBar1.Visible = false;

                AgregarLogCompleto("Filtros", "Filtros aplicados correctamente");
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                AgregarLogCompleto("Error", "Error al filtrar: " + ex.Message);
                MessageBox.Show("Error al filtrar: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarInterfazCompleta()
        {
            try
            {
                AgregarLog("Iniciando actualización de interfaz...");

                AgregarLog($"Ventas filtradas: {analisisService.VentasFiltradas?.Count ?? 0}");

                // 1. Obtén los productos más vendidos
                var topProductos = analisisService.TopProductos();
                // 2. Log detallado para depuración
                if (topProductos.Count > 0)
                {
                    foreach (var prod in topProductos)
                    {
                        AgregarLog($"Producto: {prod.Producto}, Total: {prod.Total}");
                    }
                }

                var ventasPorMes = analisisService.VentasPorMes();

                AgregarLog($"Datos para gráfico de productos: {topProductos.Count} elementos");
                AgregarLog($"Datos para gráfico de meses: {ventasPorMes.Count} elementos");

                // ACTUALIZAR LABELS DE ESTADÍSTICAS
                lblTotal.Text = analisisService.TotalGanancias.ToString("C");
                 topProductos = analisisService.TopProductos();
                if (topProductos.Count > 0)
                {
                    lblMejorProducto.Text = topProductos[0].Producto;
                    AgregarLog($"Producto estrella actualizado: {topProductos[0].Producto} con {topProductos[0].Total} unidades");
                }
                else
                {
                    lblMejorProducto.Text = "N/A";
                }
                lblVentasMensuales.Text = analisisService.PromedioVentasMensuales().ToString("C");

                // FORZAR ACTUALIZACIÓN DE GRÁFICOS EN EL HILO PRINCIPAL
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new Action(() => {
                        ActualizarGraficos(topProductos, ventasPorMes);
                    }));
                }
                else
                {
                    ActualizarGraficos(topProductos, ventasPorMes);
                }

                // ACTUALIZAR COMBOS (solo si están vacíos)
                if (cbProducto.Items.Count == 0)
                {
                    cbProducto.Items.Clear();
                    cbProducto.Items.Add("Todos");
                    foreach (var producto in analisisService.TodosLosProductos())
                    {
                        cbProducto.Items.Add(producto);
                    }
                }

                if (cbCategoria.Items.Count == 0)
                {
                    cbCategoria.Items.Clear();
                    cbCategoria.Items.Add("Todas");
                    foreach (var categoria in analisisService.TodasLasCategorias())
                    {
                        cbCategoria.Items.Add(categoria);
                    }
                }

                // ACTUALIZAR DATAGRID
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = analisisService.VentasFiltradas;

                AgregarLog("Interfaz actualizada correctamente.");
            }
            catch (Exception ex)
            {
                AgregarLog("Error al actualizar interfaz: " + ex.Message);
                AgregarLog("Stack trace: " + ex.StackTrace);
            }
        }

        // NUEVO MÉTODO: Agregar este método después de ActualizarInterfazCompleta
        private void ActualizarGraficos(List<(string Producto, int Total)> topProductos, List<(string Mes, decimal Total)> ventasPorMes)
        {
            try
            {
                // 3. Actualiza el gráfico de productos con RECREACIÓN COMPLETA
                if (topProductos.Count > 0)
                {
                    graficoService.GenerarGraficoProductos(topProductos, chartProductos);

                    // FORZAR actualización adicional
                    Application.DoEvents(); // Procesar eventos pendientes
                    chartProductos.Update();
                    chartProductos.Invalidate();
                    chartProductos.Refresh();

                    AgregarLog("Gráfico de productos generado correctamente");
                }
                else
                {
                    graficoService.GenerarGraficoProductos(new List<(string Producto, int Total)>(), chartProductos);
                    chartProductos.Update();
                    chartProductos.Invalidate();
                    chartProductos.Refresh();
                    AgregarLog("No hay datos para el gráfico de productos");
                }

                // 4. Actualiza el gráfico de meses
                if (ventasPorMes.Count > 0)
                {
                    graficoService.GenerarGraficoMeses(ventasPorMes, chartMeses);

                    // FORZAR actualización adicional
                    Application.DoEvents();
                    chartMeses.Update();
                    chartMeses.Invalidate();
                    chartMeses.Refresh();

                    AgregarLog("Gráfico de meses generado correctamente");
                }
                else
                {
                    graficoService.GenerarGraficoMeses(new List<(string Mes, decimal Total)>(), chartMeses);
                    chartMeses.Update();
                    chartMeses.Invalidate();
                    chartMeses.Refresh();
                    AgregarLog("No hay datos para el gráfico de meses");
                }
            }
            catch (Exception ex)
            {
                AgregarLog("Error al actualizar gráficos: " + ex.Message);
            }
        }



        private ReporteService reporteService = new ReporteService();
        private async void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (analisisService.VentasFiltradas == null || analisisService.VentasFiltradas.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Archivo PDF (*.pdf)|*.pdf|Archivo Excel (*.xlsx)|*.xlsx|Archivo CSV (*.csv)|*.csv";
                    saveDialog.Title = "Guardar reporte";
                    saveDialog.FileName = "Reporte_Ventas_" + DateTime.Now.ToString("yyyyMMdd");

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        progressBar1.Value = 0;
                        progressBar1.Visible = true;

                        var progressTimer = new System.Windows.Forms.Timer();
                        progressTimer.Interval = 100;
                        int progressValue = 0;
                        progressTimer.Tick += (s, ev) => {
                            progressValue += 5;
                            if (progressValue <= 95)
                                progressBar1.Value = progressValue;
                            else
                                progressTimer.Stop();
                        };
                        progressTimer.Start();

                        AgregarLogCompleto("Exportación", "Iniciando exportación a " + saveDialog.FileName);

                        string rutaFinal = "";
                        if (saveDialog.FileName.EndsWith(".pdf"))
                        {
                            // 1. Llama a la IA para obtener el análisis
                            string apiKey = "sk-2lktrQ5V_N_u6Tec6dZjXSavMsuZJjJxP2g1FqO8D4z7OH5ITNmDMpwy0Y6k5SUN7j0QyA6mII1ra-8-IuF01hXMlAGr"; // Cambia por tu API key segura
                            string resumenIA = await reporteService.ObtenerAnalisisIAAsync(analisisService.VentasFiltradas, apiKey);

                            // 2. Exporta el PDF con el análisis de la IA
                            rutaFinal = await reporteService.ExportarVentasPDFAsync(analisisService.VentasFiltradas, saveDialog.FileName, resumenIA);

                            // ¡No se muestra nada en pantalla!
                        }
                        else
                        {
                            // Exporta Excel o CSV como antes
                            rutaFinal = await reporteService.ExportarVentasAsync(analisisService.VentasFiltradas, saveDialog.FileName);
                        }

                        progressTimer.Stop();
                        progressBar1.Value = 100;
                        await Task.Delay(1000);
                        progressBar1.Visible = false;

                        AgregarLogCompleto("Exportación", "Datos exportados exitosamente a " + rutaFinal);
                        MessageBox.Show("Exportación completada a " + rutaFinal, "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AgregarLog("Exportación cancelada por el usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                AgregarLogCompleto("Error", "Error al exportar: " + ex.Message);
                MessageBox.Show("Error al exportar: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFiltros();

                if (ventas != null && ventas.Count > 0)
                {
                    analisisService.Analizar(ventas);

                    ActualizarInterfazCompleta();
                }

                AgregarLogCompleto("Filtros", "Se han limpiado todos los filtros");
            }
            catch (Exception ex)
            {
                AgregarLogCompleto("Error", "Error al limpiar filtros: " + ex.Message);
                MessageBox.Show("Error al limpiar filtros: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void SimularVentas(List<Venta> listaVentas)
        {
      
            btnSimular.Text = "▶️ Simulando...";
            btnSimular.Enabled = false;

            ActualizarInterfazCompleta();

            try
            {
                var ventasSimuladas = new List<Venta>();

                for (; ventaActual < listaVentas.Count; ventaActual++)
                {
                   

                    ventasSimuladas.Add(listaVentas[ventaActual]);
                    analisisService.Analizar(ventasSimuladas);

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() => ActualizarInterfazCompleta()));
                    }
                    else
                    {
                        ActualizarInterfazCompleta();
                    }

                    Application.DoEvents();

                    AgregarLog($"📊 Procesando venta {ventaActual + 1} de {listaVentas.Count}");

                    await Task.Delay(1000); // Aumenté el delay para ver mejor los cambios
                }

                FinalizarSimulacion();
                AgregarLog("✅ Simulación completada exitosamente, Jona.");
            }
            catch (OperationCanceledException)
            {
                AgregarLog("⏹️ Operación cancelada");
            }
            catch (Exception ex)
            {
                AgregarLog("❌ Error en simulación: " + ex.Message);
                FinalizarSimulacion();
            }
        }


        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (ventas == null || ventas.Count == 0)
            {
                MessageBox.Show("Carga primero las ventas, Jona.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            else
            {
                AgregarLog("🚀 Iniciando nueva simulación de ventas");
                ventaActual = 0; // Solo aquí se reinicia
                analisisService.VentasFiltradas.Clear();
            }

            SimularVentas(ventas);
        }


        

        private void FinalizarSimulacion(bool limpiar = false)
        {
           
            btnSimular.Text = "▶️ Simular ventas";
            btnSimular.Enabled = true;

          

            if (limpiar)
            {
                ventaActual = 0;
                analisisService.VentasFiltradas.Clear();
            }

            AgregarLog("🔄 Simulación finalizada. Botones restablecidos.");
        }


    }
}
