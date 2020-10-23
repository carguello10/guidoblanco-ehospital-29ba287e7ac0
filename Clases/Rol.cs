using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Rol
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public static void Agregar(Rol rol) { }
        public static void Editar(Rol rol) { }
        public static void Eliminar(int codigoRol) { }
        public static List<Rol> ObtenerListado()
        {
            return null;
        }
    }
}
