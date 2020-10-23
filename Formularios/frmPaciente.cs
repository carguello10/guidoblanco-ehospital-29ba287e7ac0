using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPaciente : Form
    {
        private string accion = "AGREGAR";
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                return;
            }

            Paciente paciente = new Paciente();
            paciente.FechaNacimiento = dtpFechaNacimiento.Value;
            paciente.FechaAltaIngreso = dtpFechaAltaIngreso.Value;
            if (accion == "AGREGAR")
            {
                Paciente.Agregar(paciente);
            }
            else
            {
                paciente.CodigoPaciente = Convert.ToInt32(txtCodigo.Text);
                Paciente.Editar(paciente);
            }

            MessageBox.Show("Se guardó correctamente el Paciente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar el Paciente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int codigoPaciente = Convert.ToInt32(txtCodigo.Text);
                TipoServicio.Eliminar(codigoPaciente);

                MessageBox.Show("Se eliminó correctamente el paciente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private bool validarFormulario()
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento debe ser anterior a la fecha de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNacimiento.Focus();
                return false;
            }

            if (dtpFechaAltaIngreso.Value <= DateTime.Now)
            {
                MessageBox.Show("La fecha de ingreso debe ser mayor a la de hoy, o debe ser hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaAltaIngreso.Focus();
                return false;
            }

            return true;
        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaAltaIngreso.Value = DateTime.Now;

            dtpFechaNacimiento.Focus();
            accion = "AGREGAR";
        }
    }
}
