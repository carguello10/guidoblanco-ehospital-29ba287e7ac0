using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public int CodigoProducto { get; set; }
        public String Descripcion { get; set; }
        public int CostoProducto { get; set; }
        public int PrecioVenta { get; set; }
        public TipoPresentacion Presentacion { get; set; }
        public int Existencia { get; set; }

        public Producto() { }

        public Producto(int codigoProducto, string descripcion, int costoProducto, int precioVenta, TipoPresentacion presentacion, int existencia)
        {
            this.CodigoProducto = codigoProducto;
            this.Descripcion = descripcion;
            this.CostoProducto = costoProducto;
            this.PrecioVenta = precioVenta;
            this.Presentacion = presentacion;
            this.Existencia = existencia;
        }
    }
}
