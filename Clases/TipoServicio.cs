using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoServicio
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }

        public static void Agregar(TipoServicio tipoServicio) { }
        public static void Editar(TipoServicio tipoServicio) { }
        public static void Eliminar(int codigoTipoServicio) { }
        public static List<TipoServicio> ObtenerListado() {
            return null;
        }
    }
}
