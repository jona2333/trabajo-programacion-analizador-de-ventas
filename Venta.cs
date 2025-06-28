using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorVentasRopa.Models
{
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }

}
