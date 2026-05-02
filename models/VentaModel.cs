using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.S.S.models
{
    internal class VentaModel
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
