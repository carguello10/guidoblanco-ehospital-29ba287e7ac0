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
    public partial class frmDoctor : Form
    {
        private String accion = "AGREGAR";
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                return;
            }

            Doctor doctor = new Doctor();
            doctor.Nombres = txtNombres.Text;
            doctor.Apellidos = txtApellidos.Text;
            doctor.RegistroProfesional = txtRegProf.Text;
            doctor.NroContacto = txtNumeroContacto.Text;
            if(accion == "AGREGAR")
            {
                Doctor.Agregar(doctor);
                ActualizarListaDoctores();
            }
            else
            {
                doctor.Codigo = Convert.ToInt32(txtCodigo.Text);
                Doctor.Editar(doctor);
                ActualizarListaDoctores();
            }

            MessageBox.Show("Se guardó correctamente el Doctor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar a el Doctor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int codigoDoctor = Convert.ToInt32(txtCodigo.Text);
                Doctor.Eliminar(codigoDoctor);
                ActualizarListaDoctores();

                MessageBox.Show("Se eliminó correctamente el doctor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private bool validarFormulario()
        {
            if (!cmbEspecialidad.SelectedItem.Equals("Urólogo") || !cmbEspecialidad.SelectedItem.Equals("Otorrinonaringologo") || !cmbEspecialidad.SelectedItem.Equals("Pediatra") || !cmbEspecialidad.SelectedItem.Equals("Proctólogo") || !cmbEspecialidad.SelectedItem.Equals("Neumólogo") || !cmbEspecialidad.SelectedItem.Equals("otros"))
            {
                MessageBox.Show("El tipo de especialidad no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEspecialidad.Focus();
                return false;
            }

            if (!cmbTipoDoc.SelectedItem.Equals("Cedula de Identidad") || !cmbTipoDoc.SelectedItem.Equals("DNI"))
            {
                MessageBox.Show("El tipo de documento no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTipoDoc.Focus();
                return false;
            }

            return true;
        }
        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNroDoc.Clear();
            txtNumeroContacto.Clear();
            txtRegProf.Clear();
            cmbEspecialidad.Text = "";
            cmbTipoDoc.Text = "";
            accion = "AGREGAR";
        }

        private void ActualizarListaDoctores()
        {
            lsbDoctores.DataSource = null;
            lsbDoctores.DataSource = Doctor.ObtenerLista();
        }
    }
}
