using System;
using Clases;
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
    public partial class frmRol : Form
    {
        private string accion = "AGREGAR";
        public frmRol()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                return;
            }

            Rol rol = new Rol();
            rol.Descripcion = txtDescripcion.Text;
            if (accion == "AGREGAR")
            {
                Rol.Agregar(rol);
            }
            else
            {
                rol.Codigo = Convert.ToInt32(txtCodigo.Text);
                Rol.Editar(rol);
            }

            MessageBox.Show("Se guardó correctamente el Rol", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar el Rol?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int codigoRol = Convert.ToInt32(txtCodigo.Text);
                Rol.Eliminar(codigoRol);

                MessageBox.Show("Se eliminó correctamente el Rol", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private bool validarFormulario()
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debes ingresar la descripción del Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            txtDescripcion.Focus();
            accion = "AGREGAR";
        }

    
    }
}
