using AnalizadorVentasRopa.Models;
using ExcelDataReader;
using System.Collections.Generic;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace AnalizadorVentasRopa.Services
{
    public class ExcelService
    {
        public List<Venta> LeerVentasDesdeExcel(string rutaArchivo)
        {
            var ventas = new List<Venta>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                    var conf = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };
                var result = reader.AsDataSet(conf);
                var table = result.Tables[0];

                var nombres = table.Columns.Cast<DataColumn>().Select(c => c.ColumnName.Trim().ToLower()).ToList();
                if (!nombres.Contains("fecha") ||
                    !nombres.Contains("producto") ||
                    !nombres.Contains("cantidad") ||
                    !nombres.Contains("precio") ||
                    !nombres.Contains("categoria")
                    )
                {
                    throw new Exception("El archivo debe tener las columnas: Fecha, Producto, Cantidad, Precio, Categoria");
                }

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var row = table.Rows[i];
                    ventas.Add(new Venta
                    {
                        Fecha = Convert.ToDateTime(row["fecha"]),
                        Producto = row["producto"].ToString(),
                        Cantidad = Convert.ToInt32(row["cantidad"]),
                        Precio = Convert.ToDecimal(row["precio"]),
                        Categoria = row["categoria"].ToString() 
                    });
                }
            }
            return ventas;
        }


    }
}
