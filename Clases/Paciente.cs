using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Paciente : Persona
    {
        public int CodigoPaciente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAltaIngreso { get; set; }
        
        public Paciente() { }
        public Paciente(string nombres, string apellidos, List<Documento> documentos, int codigoPaciente, DateTime fechaNacimiento, DateTime fechaAltaIngreso)
            : base(nombres, apellidos, documentos)
        {
            this.CodigoPaciente = codigoPaciente;
            this.FechaNacimiento = fechaNacimiento;
            this.FechaAltaIngreso = fechaAltaIngreso;
        }

        public static void Agregar(Paciente paciente) { }
        public static void Editar(Paciente paciente) { }
        public static void Eliminar(int codigoPaciente) { }
        public static List<Paciente> ObtenerListado() {
            return null;
        }
    }
}
