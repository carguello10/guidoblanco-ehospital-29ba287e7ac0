using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ServicioPaciente
    {
        public DateTime Fecha { get; set; }
        public Servicio Servicio { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
        public int Precio { get; set; }
        public List<DetalleProducto> DetalleProducto { get; set; }
        public bool EstadoPagoProductos { get; set; }

        public ServicioPaciente()  { }
        public ServicioPaciente(DateTime fecha, Servicio servicio, Paciente paciente, Doctor doctor, int precio, List<DetalleProducto> detalleProducto, bool estadoPagoProductos)
        
        {
            this.Fecha = fecha;
            this.Servicio = servicio;
            this.Paciente = paciente;
            this.Doctor = doctor;
            this.Precio = precio;
            this.DetalleProducto = detalleProducto;
            this.EstadoPagoProductos = estadoPagoProductos;
        }
    }
}
