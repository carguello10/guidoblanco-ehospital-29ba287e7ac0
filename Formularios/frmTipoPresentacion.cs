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
    public partial class frmTipoPresentacion : Form
    {
        private string accion = "AGREGAR";
        public frmTipoPresentacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                return;
            }

            TipoPresentacion tipoPresentacion = new TipoPresentacion();
            tipoPresentacion.Descripcion = txtDescripcion.Text;
            if (accion == "AGREGAR")
            {
                TipoPresentacion.Agregar(tipoPresentacion);
            }
            else
            {
                tipoPresentacion.Codigo = Convert.ToInt32(txtCodigo.Text);
                TipoPresentacion.Editar(tipoPresentacion);
            }

            MessageBox.Show("Se guardó correctamente el Tipo de Presentación", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar el Tipo de Presentación?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int codigoTipoPresentacion = Convert.ToInt32(txtCodigo.Text);
                TipoPresentacion.Eliminar(codigoTipoPresentacion);

                MessageBox.Show("Se eliminó correctamente el Tipo de Presentación", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Debés ingresar la descripción del Tipo de Presentación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
