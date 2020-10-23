using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Doctor : Persona
    {
        public int Codigo { get; set; }
        public string RegistroProfesional { get; set; }
        public Especialidad Especialidad { get; set; }
        public string NroContacto { get; set; }
        private List<Doctor> ListaDoctores = new List<Doctor>();
        public Doctor() { }
        public Doctor(string nombres, string apellidos, List<Documento> documentos, int codigoPaciente, string registroProfesional, Especialidad especialidad, string nroContacto)
            : base(nombres, apellidos, documentos)
        {
            this.Codigo = codigoPaciente;
            this.RegistroProfesional = registroProfesional;
            this.Especialidad = especialidad;
            this.NroContacto = nroContacto;
        }
        public static void Agregar(Doctor doctor) { }
        public static void Editar(Doctor doctor) { }
        public static void Eliminar(int codigoDoctor) { }
        public static List<Doctor> ObtenerLista()
        {
            return null;
        }
    }

}
