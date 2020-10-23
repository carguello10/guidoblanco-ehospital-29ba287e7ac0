using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public List<Documento> Documentos { get; set; }

        public Persona() { }
        public Persona(string nombres, string apellidos, List<Documento> documentos)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Documentos = documentos;
        }
    }
}
