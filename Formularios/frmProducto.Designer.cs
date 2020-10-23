namespace Formularios
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSistema = new System.Windows.Forms.Label();
            this.tbcPaciente = new System.Windows.Forms.TabControl();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.nudCostoProducto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbExistencia = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.tbcPaciente.SuspendLayout();
            this.tbpMantenimiento.SuspendLayout();
            this.tbpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoProducto)).BeginInit();
            this.gpbExistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(116, 32);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(137, 31);
            this.lblSistema.TabIndex = 7;
            this.lblSistema.Text = "eHospital";
            // 
            // tbcPaciente
            // 
            this.tbcPaciente.Controls.Add(this.tbpMantenimiento);
            this.tbcPaciente.Controls.Add(this.tbpListado);
            this.tbcPaciente.Location = new System.Drawing.Point(116, 120);
            this.tbcPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.tbcPaciente.Name = "tbcPaciente";
            this.tbcPaciente.SelectedIndex = 0;
            this.tbcPaciente.Size = new System.Drawing.Size(568, 298);
            this.tbcPaciente.TabIndex = 6;
            // 
            // tbpMantenimiento
            // 
            this.tbpMantenimiento.Controls.Add(this.gpbExistencia);
            this.tbpMantenimiento.Controls.Add(this.lblExistencia);
            this.tbpMantenimiento.Controls.Add(this.txtPresentacion);
            this.tbpMantenimiento.Controls.Add(this.label1);
            this.tbpMantenimiento.Controls.Add(this.nudPrecioVenta);
            this.tbpMantenimiento.Controls.Add(this.nudCostoProducto);
            this.tbpMantenimiento.Controls.Add(this.lblPrecioVenta);
            this.tbpMantenimiento.Controls.Add(this.lblPresentacion);
            this.tbpMantenimiento.Controls.Add(this.txtDescripcion);
            this.tbpMantenimiento.Controls.Add(this.lblDescripcion);
            this.tbpMantenimiento.Controls.Add(this.btnEliminar);
            this.tbpMantenimiento.Controls.Add(this.btnCancelar);
            this.tbpMantenimiento.Controls.Add(this.btnGuardar);
            this.tbpMantenimiento.Controls.Add(this.lblCodigo);
            this.tbpMantenimiento.Controls.Add(this.txtCodigo);
            this.tbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.tbpMantenimiento.Name = "tbpMantenimiento";
            this.tbpMantenimiento.Padding = new System.Windows.Forms.Padding(2);
            this.tbpMantenimiento.Size = new System.Drawing.Size(560, 272);
            this.tbpMantenimiento.TabIndex = 0;
            this.tbpMantenimiento.Text = "Mantenimiento";
            this.tbpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(242, 240);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(316, 240);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(168, 240);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 28);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(143, 20);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(270, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(145, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // tbpListado
            // 
            this.tbpListado.Controls.Add(this.dgvPaciente);
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Margin = new System.Windows.Forms.Padding(2);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(2);
            this.tbpListado.Size = new System.Drawing.Size(560, 272);
            this.tbpListado.TabIndex = 1;
            this.tbpListado.Text = "Listado";
            this.tbpListado.UseVisualStyleBackColor = true;
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaciente.Location = new System.Drawing.Point(2, 2);
            this.dgvPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.RowHeadersWidth = 51;
            this.dgvPaciente.RowTemplate.Height = 24;
            this.dgvPaciente.Size = new System.Drawing.Size(556, 268);
            this.dgvPaciente.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(117, 68);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Productos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(143, 57);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(270, 57);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(145, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.Location = new System.Drawing.Point(270, 116);
            this.nudPrecioVenta.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(145, 20);
            this.nudPrecioVenta.TabIndex = 46;
            // 
            // nudCostoProducto
            // 
            this.nudCostoProducto.Location = new System.Drawing.Point(270, 87);
            this.nudCostoProducto.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudCostoProducto.Name = "nudCostoProducto";
            this.nudCostoProducto.Size = new System.Drawing.Size(145, 20);
            this.nudCostoProducto.TabIndex = 45;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(143, 118);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVenta.TabIndex = 44;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(143, 146);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(69, 13);
            this.lblPresentacion.TabIndex = 43;
            this.lblPresentacion.Text = "Presentacion";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(270, 143);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(145, 20);
            this.txtPresentacion.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Descripcion";
            // 
            // gpbExistencia
            // 
            this.gpbExistencia.Controls.Add(this.rdbNo);
            this.gpbExistencia.Controls.Add(this.rdbSi);
            this.gpbExistencia.Location = new System.Drawing.Point(270, 168);
            this.gpbExistencia.Name = "gpbExistencia";
            this.gpbExistencia.Size = new System.Drawing.Size(145, 51);
            this.gpbExistencia.TabIndex = 50;
            this.gpbExistencia.TabStop = false;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(80, 19);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 15;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(6, 19);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 14;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(139, 195);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(55, 13);
            this.lblExistencia.TabIndex = 49;
            this.lblExistencia.Text = "Existencia";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.tbcPaciente);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.tbcPaciente.ResumeLayout(false);
            this.tbpMantenimiento.ResumeLayout(false);
            this.tbpMantenimiento.PerformLayout();
            this.tbpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoProducto)).EndInit();
            this.gpbExistencia.ResumeLayout(false);
            this.gpbExistencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TabControl tbcPaciente;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.NumericUpDown nudCostoProducto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbExistencia;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblExistencia;
    }
}