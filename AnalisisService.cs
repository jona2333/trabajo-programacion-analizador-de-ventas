using AnalizadorVentasRopa.Models;
using System.Collections.Generic;
using System;
using System.Linq;


namespace AnalizadorVentasRopa.Services
{
    public class AnalisisService
    {
        public decimal TotalGanancias { get; private set; }
        public string MejorProducto { get; private set; }

        public List<Venta> VentasFiltradas { get; private set; } = new List<Venta>();

        public void Analizar(List<Venta> ventas, DateTime? fechaInicio = null, DateTime? fechaFin = null, string producto = null, string categoria = null)
        {
            VentasFiltradas = ventas.Where(v =>
                (!fechaInicio.HasValue || v.Fecha >= fechaInicio.Value) &&
                (!fechaFin.HasValue || v.Fecha <= fechaFin.Value) &&
                (string.IsNullOrEmpty(producto) || v.Producto == producto) &&
                (string.IsNullOrEmpty(categoria) || v.Categoria == categoria)
            ).ToList();

            TotalGanancias = VentasFiltradas.Sum(v => v.Cantidad * v.Precio);
            MejorProducto = VentasFiltradas
                .GroupBy(v => v.Producto)
                .OrderByDescending(g => g.Sum(v => v.Cantidad * v.Precio))
                .FirstOrDefault()?.Key;
        }

        public List<(string Producto, int Total)> TopProductos()
        {
            return VentasFiltradas
                .GroupBy(v => v.Producto)
                .Select(g => (g.Key, g.Sum(v => v.Cantidad)))
                .OrderByDescending(t => t.Item2)
                .ToList();
        }

        public List<(string Mes, decimal Total)> VentasPorMes()
        {
            return VentasFiltradas
                .GroupBy(v => v.Fecha.ToString("yyyy-MM"))
                .Select(g => (g.Key, g.Sum(v => v.Cantidad * v.Precio)))
                .OrderBy(t => t.Key)
                .ToList();
        }

        public List<string> TodosLosProductos()
        {
            return VentasFiltradas
                .Select(v => v.Producto)
                .Distinct()
                .OrderBy(p => p)
                .ToList();
        }

        public List<string> TodasLasCategorias()
        {
            return VentasFiltradas
                .Select(v => v.Categoria)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        public decimal PromedioVentasMensuales()
        {
            var ventasPorMes = VentasPorMes();
            return ventasPorMes.Count > 0 ? ventasPorMes.Average(v => v.Total) : 0;
        }
    }
}
