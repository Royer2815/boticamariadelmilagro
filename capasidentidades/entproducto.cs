using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasEdentidades
{
    internal class entproducto
    {
        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
        }

        public class Venta
        {
            public int Id { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
            public DateTime Fecha { get; set; }
            public List<DetalleVenta> Detalles { get; set; }
        }

        public class DetalleVenta
        {
            public int Id { get; set; }
            public int VentaId { get; set; }
            public Venta Venta { get; set; }
            public int ProductoId { get; set; }
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
        }
    }
}
