namespace Formularios
{
    partial class frmPaciente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.tbcPaciente = new System.Windows.Forms.TabControl();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.dtpFechaAltaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAltaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.tbcPaciente.SuspendLayout();
            this.tbpMantenimiento.SuspendLayout();
            this.tbpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 50);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Mantenimiento de Paciente";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(9, 14);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(137, 31);
            this.lblSistema.TabIndex = 4;
            this.lblSistema.Text = "eHospital";
            // 
            // tbcPaciente
            // 
            this.tbcPaciente.Controls.Add(this.tbpMantenimiento);
            this.tbcPaciente.Controls.Add(this.tbpListado);
            this.tbcPaciente.Location = new System.Drawing.Point(9, 102);
            this.tbcPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.tbcPaciente.Name = "tbcPaciente";
            this.tbcPaciente.SelectedIndex = 0;
            this.tbcPaciente.Size = new System.Drawing.Size(568, 298);
            this.tbcPaciente.TabIndex = 3;
            // 
            // tbpMantenimiento
            // 
            this.tbpMantenimiento.Controls.Add(this.dtpFechaAltaIngreso);
            this.tbpMantenimiento.Controls.Add(this.lblFechaAltaIngreso);
            this.tbpMantenimiento.Controls.Add(this.dtpFechaNacimiento);
            this.tbpMantenimiento.Controls.Add(this.btnEliminar);
            this.tbpMantenimiento.Controls.Add(this.btnCancelar);
            this.tbpMantenimiento.Controls.Add(this.btnGuardar);
            this.tbpMantenimiento.Controls.Add(this.lblCodigo);
            this.tbpMantenimiento.Controls.Add(this.txtCodigo);
            this.tbpMantenimiento.Controls.Add(this.lblFechaNacimiento);
            this.tbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.tbpMantenimiento.Name = "tbpMantenimiento";
            this.tbpMantenimiento.Padding = new System.Windows.Forms.Padding(2);
            this.tbpMantenimiento.Size = new System.Drawing.Size(560, 272);
            this.tbpMantenimiento.TabIndex = 0;
            this.tbpMantenimiento.Text = "Mantenimiento";
            this.tbpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dtpFechaAltaIngreso
            // 
            this.dtpFechaAltaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAltaIngreso.Location = new System.Drawing.Point(275, 132);
            this.dtpFechaAltaIngreso.Name = "dtpFechaAltaIngreso";
            this.dtpFechaAltaIngreso.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaAltaIngreso.TabIndex = 9;
            // 
            // lblFechaAltaIngreso
            // 
            this.lblFechaAltaIngreso.AutoSize = true;
            this.lblFechaAltaIngreso.Location = new System.Drawing.Point(148, 132);
            this.lblFechaAltaIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaAltaIngreso.Name = "lblFechaAltaIngreso";
            this.lblFechaAltaIngreso.Size = new System.Drawing.Size(108, 13);
            this.lblFechaAltaIngreso.TabIndex = 8;
            this.lblFechaAltaIngreso.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(275, 96);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(248, 176);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 176);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(174, 176);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 28);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(148, 61);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(275, 58);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(117, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(148, 96);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
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
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 414);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.tbcPaciente);
            this.Name = "frmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Pacientes";
            this.tbcPaciente.ResumeLayout(false);
            this.tbpMantenimiento.ResumeLayout(false);
            this.tbpMantenimiento.PerformLayout();
            this.tbpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TabControl tbcPaciente;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaAltaIngreso;
        private System.Windows.Forms.Label lblFechaAltaIngreso;
    }
}