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
    public partial class frmTipoServicio : Form
    {
        private string accion = "AGREGAR";
        public frmTipoServicio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                return;
            }

            TipoServicio tipoServicio = new TipoServicio();
            tipoServicio.Descripcion = txtDescripcion.Text;
            if (accion == "AGREGAR")
            {
                TipoServicio.Agregar(tipoServicio);
            } else
            {
                tipoServicio.Codigo = Convert.ToInt32(txtCodigo.Text);
                TipoServicio.Editar(tipoServicio);
            }

            MessageBox.Show("Se guardó correctamente el Tipo de Servicio", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar el Tipo de Servicio?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int codigoTipoServicio = Convert.ToInt32(txtCodigo.Text);
                TipoServicio.Eliminar(codigoTipoServicio);

                MessageBox.Show("Se eliminó correctamente el Tipo de Servicio", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Debés ingresar la descripción del Tipo de Servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
