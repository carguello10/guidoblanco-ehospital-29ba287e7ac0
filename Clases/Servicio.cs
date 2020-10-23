using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Servicio
    {
        public int CodigoServicio { get; set; }
        public String Descripcion { get; set; }
        public int Precio { get; set; }
        public bool Estado  { get; set; }
        public TipoServicio TipoServicio { get; set; }
    

        public Servicio() { }
        public Servicio(int codigoServicio, string descripcion, int precio, TipoServicio tipoServicio)
        {

            this.CodigoServicio = codigoServicio;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.TipoServicio = TipoServicio;

        }
    }
}
