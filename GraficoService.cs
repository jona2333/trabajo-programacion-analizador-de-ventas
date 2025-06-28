using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnalizadorVentasRopa.Services
{
    public class GraficoService
    {
        public void GenerarGraficoProductos(List<(string Producto, int Total)> topProductos, Chart chart)
        {
            if (chart.InvokeRequired)
            {
                chart.BeginInvoke(new Action(() => ActualizarGraficoProductos(topProductos, chart)));
            }
            else
            {
                ActualizarGraficoProductos(topProductos, chart);
            }
        }

        private void ActualizarGraficoProductos(List<(string Producto, int Total)> topProductos, Chart chart)
        {
            try
            {
                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Legends.Clear();

                var chartArea = new ChartArea("ChartArea1");
                chartArea.AxisX.LabelStyle.Angle = -45;
                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = true;
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
                chart.ChartAreas.Add(chartArea);

                var legend = new Legend("Legend1");
                chart.Legends.Add(legend);

                var serie = new Series("Más Vendidos")
                {
                    ChartType = SeriesChartType.Column,
                    ChartArea = "ChartArea1",
                    Legend = "Legend1"
                };

                foreach (var prod in topProductos)
                {
                    var point = serie.Points.AddXY(prod.Producto, prod.Total);
                    serie.Points[serie.Points.Count - 1].Color = GetColorForIndex(serie.Points.Count - 1);
                }

                chart.Series.Add(serie);

                chart.Visible = true;
                chart.Update();
                chart.Invalidate();
                chart.Refresh();

                Console.WriteLine($"Gráfico actualizado con {topProductos.Count} productos");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar gráfico de productos: {ex.Message}");
            }
        }

        private Color GetColorForIndex(int index)
        {
            Color[] colors = {
                Color.FromArgb(124, 65, 153),   // Púrpura
                Color.FromArgb(0, 174, 219),    // Azul
                Color.FromArgb(0, 177, 89),     // Verde
                Color.FromArgb(209, 17, 65),    // Rojo
                Color.FromArgb(255, 140, 0),    // Naranja
                Color.FromArgb(128, 128, 128)   // Gris
            };
            return colors[index % colors.Length];
        }

        public void GenerarGraficoMeses(List<(string Mes, decimal Total)> ventasPorMes, Chart chart)
        {
            if (chart.InvokeRequired)
            {
                chart.BeginInvoke(new Action(() => ActualizarGraficoMeses(ventasPorMes, chart)));
            }
            else
            {
                ActualizarGraficoMeses(ventasPorMes, chart);
            }
        }

        private void ActualizarGraficoMeses(List<(string Mes, decimal Total)> ventasPorMes, Chart chart)
        {
            try
            {
                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Legends.Clear();

                var chartArea = new ChartArea("ChartArea1");
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = true;
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
                chart.ChartAreas.Add(chartArea);

                var legend = new Legend("Legend1");
                chart.Legends.Add(legend);

                var serie = new Series("Ventas por Mes")
                {
                    ChartType = SeriesChartType.Line,
                    ChartArea = "ChartArea1",
                    Legend = "Legend1",
                    BorderWidth = 3,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    Color = Color.FromArgb(124, 65, 153)
                };

                foreach (var mes in ventasPorMes)
                {
                    serie.Points.AddXY(mes.Mes, mes.Total);
                }

                chart.Series.Add(serie);

                chart.Visible = true;
                chart.Update();
                chart.Invalidate();
                chart.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar gráfico de meses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}