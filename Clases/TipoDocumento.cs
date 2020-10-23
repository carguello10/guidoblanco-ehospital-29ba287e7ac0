using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoDocumento
    {
        private int Codigo { get; set; }
        public String Descripcion { get; set; }
        public static void Agregar(TipoDocumento tipoDocumento) { }
        public static void Editar(TipoDocumento tipoDocumento) { }
        public static void Eliminar(int codigoTipoDocumento) { }
        public static List<TipoDocumento> ObtenerLista()
        {
            return null;
        }
    }
}
