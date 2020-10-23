using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado : Persona
    {
        public Rol Rol { get; set; }

        public Empleado() { }
        public Empleado(string nombres, string apellidos, List<Documento> documentos, Rol rol) 
            : base (nombres, apellidos, documentos)
        {
            this.Rol = rol;
        }
    }
}
