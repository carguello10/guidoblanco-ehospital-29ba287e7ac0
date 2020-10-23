using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoPresentacion
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }

        public static void Agregar(TipoPresentacion tipoPresentacion) { }
        public static void Editar(TipoPresentacion tipoPresentacion) { }
        public static void Eliminar(int codigoTipoPresentacion) { }
        public static List<TipoPresentacion> ObtenerListado()
        {
            return null;
        }
    }
}
