namespace Formularios
{
    partial class frmTipoPresentacion
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
            this.tbcTipoServicio = new System.Windows.Forms.TabControl();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            this.tbcTipoServicio.SuspendLayout();
            this.tbpMantenimiento.SuspendLayout();
            this.tbpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 50);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Tipos de Presentación";
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
            // tbcTipoServicio
            // 
            this.tbcTipoServicio.Controls.Add(this.tbpMantenimiento);
            this.tbcTipoServicio.Controls.Add(this.tbpListado);
            this.tbcTipoServicio.Location = new System.Drawing.Point(9, 102);
            this.tbcTipoServicio.Margin = new System.Windows.Forms.Padding(2);
            this.tbcTipoServicio.Name = "tbcTipoServicio";
            this.tbcTipoServicio.SelectedIndex = 0;
            this.tbcTipoServicio.Size = new System.Drawing.Size(568, 298);
            this.tbcTipoServicio.TabIndex = 3;
            // 
            // tbpMantenimiento
            // 
            this.tbpMantenimiento.Controls.Add(this.btnEliminar);
            this.tbpMantenimiento.Controls.Add(this.btnCancelar);
            this.tbpMantenimiento.Controls.Add(this.btnGuardar);
            this.tbpMantenimiento.Controls.Add(this.lblCodigo);
            this.tbpMantenimiento.Controls.Add(this.txtCodigo);
            this.tbpMantenimiento.Controls.Add(this.lblDescripcion);
            this.tbpMantenimiento.Controls.Add(this.txtDescripcion);
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
            this.btnEliminar.Location = new System.Drawing.Point(248, 162);
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
            this.btnCancelar.Location = new System.Drawing.Point(323, 162);
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
            this.btnGuardar.Location = new System.Drawing.Point(173, 162);
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
            this.lblCodigo.Location = new System.Drawing.Point(170, 61);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(251, 58);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(145, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(170, 96);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(251, 96);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(145, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // tbpListado
            // 
            this.tbpListado.Controls.Add(this.dgvTipoServicio);
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Margin = new System.Windows.Forms.Padding(2);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(2);
            this.tbpListado.Size = new System.Drawing.Size(560, 272);
            this.tbpListado.TabIndex = 1;
            this.tbpListado.Text = "Listado";
            this.tbpListado.UseVisualStyleBackColor = true;
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.AllowUserToAddRows = false;
            this.dgvTipoServicio.AllowUserToDeleteRows = false;
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoServicio.Location = new System.Drawing.Point(2, 2);
            this.dgvTipoServicio.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.ReadOnly = true;
            this.dgvTipoServicio.RowHeadersWidth = 51;
            this.dgvTipoServicio.RowTemplate.Height = 24;
            this.dgvTipoServicio.Size = new System.Drawing.Size(556, 268);
            this.dgvTipoServicio.TabIndex = 0;
            // 
            // frmTipoPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 414);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.tbcTipoServicio);
            this.Name = "frmTipoPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Presentación";
            this.tbcTipoServicio.ResumeLayout(false);
            this.tbpMantenimiento.ResumeLayout(false);
            this.tbpMantenimiento.PerformLayout();
            this.tbpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TabControl tbcTipoServicio;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.DataGridView dgvTipoServicio;
    }
}