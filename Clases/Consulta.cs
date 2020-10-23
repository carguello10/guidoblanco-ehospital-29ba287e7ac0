using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Consulta : ServicioPaciente
    {
        public String Sintomas { get; set; }
        public String Diagnostico { get; set; }
        public String MedicamentosRecetados { get; set; }
        public String Indicaciones { get; set; }

        public Consulta()  {}

        public Consulta(DateTime fecha, Servicio servicio, Paciente paciente, Doctor doctor, int precio, List<DetalleProducto> detalleProducto, bool estadoPagoProductos,string sintomas, 
            string diagnostico, string medicamentosRecetados, string indicaciones) 
            : base(fecha, servicio, paciente, doctor, precio, detalleProducto, estadoPagoProductos)

        {
            this.Sintomas = sintomas;
            this.Diagnostico = diagnostico;
            this.MedicamentosRecetados = medicamentosRecetados;
            this.Indicaciones = indicaciones;
        }
    }
}
