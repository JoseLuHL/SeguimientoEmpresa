namespace SeguimientoEmpresa.Formularios
{
    partial class formContrato
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
            this.DgvEmpresa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTrabajadorColTipoIden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTrabajadorColNombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFechaFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaInicio = new System.Windows.Forms.TextBox();
            this.TxtTrabajador = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblCURP = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).BeginInit();
            this.gpbxDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEmpresa
            // 
            this.DgvEmpresa.AllowUserToAddRows = false;
            this.DgvEmpresa.AllowUserToDeleteRows = false;
            this.DgvEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.DgvEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DgTrabajadorColTipoIden,
            this.DgTrabajadorColNombre1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvEmpresa.Location = new System.Drawing.Point(6, 257);
            this.DgvEmpresa.MultiSelect = false;
            this.DgvEmpresa.Name = "DgvEmpresa";
            this.DgvEmpresa.ReadOnly = true;
            this.DgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresa.Size = new System.Drawing.Size(797, 340);
            this.DgvEmpresa.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // DgTrabajadorColTipoIden
            // 
            this.DgTrabajadorColTipoIden.HeaderText = "Trabajador";
            this.DgTrabajadorColTipoIden.Name = "DgTrabajadorColTipoIden";
            this.DgTrabajadorColTipoIden.ReadOnly = true;
            this.DgTrabajadorColTipoIden.Width = 250;
            // 
            // DgTrabajadorColNombre1
            // 
            this.DgTrabajadorColNombre1.HeaderText = "Fecha";
            this.DgTrabajadorColNombre1.Name = "DgTrabajadorColNombre1";
            this.DgTrabajadorColNombre1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha Inicio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha Final";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // gpbxDatosGenerales
            // 
            this.gpbxDatosGenerales.BackColor = System.Drawing.Color.White;
            this.gpbxDatosGenerales.Controls.Add(this.TxtIdentificacion);
            this.gpbxDatosGenerales.Controls.Add(this.btnCancelar);
            this.gpbxDatosGenerales.Controls.Add(this.btnAceptar);
            this.gpbxDatosGenerales.Controls.Add(this.TxtEstado);
            this.gpbxDatosGenerales.Controls.Add(this.label2);
            this.gpbxDatosGenerales.Controls.Add(this.TxtFechaFinal);
            this.gpbxDatosGenerales.Controls.Add(this.label1);
            this.gpbxDatosGenerales.Controls.Add(this.TxtDescripcion);
            this.gpbxDatosGenerales.Controls.Add(this.label4);
            this.gpbxDatosGenerales.Controls.Add(this.TxtFechaInicio);
            this.gpbxDatosGenerales.Controls.Add(this.TxtTrabajador);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoPaterno);
            this.gpbxDatosGenerales.Controls.Add(this.lblCURP);
            this.gpbxDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxDatosGenerales.Location = new System.Drawing.Point(12, 12);
            this.gpbxDatosGenerales.Name = "gpbxDatosGenerales";
            this.gpbxDatosGenerales.Size = new System.Drawing.Size(791, 239);
            this.gpbxDatosGenerales.TabIndex = 15;
            this.gpbxDatosGenerales.TabStop = false;
            this.gpbxDatosGenerales.Text = "Datos Generales";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.Location = new System.Drawing.Point(330, 85);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(154, 26);
            this.TxtEstado.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Estado";
            // 
            // TxtFechaFinal
            // 
            this.TxtFechaFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaFinal.Location = new System.Drawing.Point(170, 85);
            this.TxtFechaFinal.Name = "TxtFechaFinal";
            this.TxtFechaFinal.Size = new System.Drawing.Size(154, 26);
            this.TxtFechaFinal.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha Final";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(10, 141);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(775, 92);
            this.TxtDescripcion.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Descripción:";
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaInicio.Location = new System.Drawing.Point(10, 85);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(154, 26);
            this.TxtFechaInicio.TabIndex = 8;
            // 
            // TxtTrabajador
            // 
            this.TxtTrabajador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTrabajador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTrabajador.Location = new System.Drawing.Point(168, 28);
            this.TxtTrabajador.MaxLength = 18;
            this.TxtTrabajador.Name = "TxtTrabajador";
            this.TxtTrabajador.Size = new System.Drawing.Size(380, 26);
            this.TxtTrabajador.TabIndex = 6;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 62);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(99, 20);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Fecha Inicio";
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Location = new System.Drawing.Point(6, 34);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(147, 20);
            this.lblCURP.TabIndex = 1;
            this.lblCURP.Text = "Tipo Identificacion:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(667, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 38);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(543, 97);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 38);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(554, 26);
            this.TxtIdentificacion.MaxLength = 18;
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(231, 26);
            this.TxtIdentificacion.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(822, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(506, 531);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Descripcion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Motivo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Resultado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // formContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbxDatosGenerales);
            this.Controls.Add(this.DgvEmpresa);
            this.Name = "formContrato";
            this.Text = "Contratos";
            this.Load += new System.EventHandler(this.formContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).EndInit();
            this.gpbxDatosGenerales.ResumeLayout(false);
            this.gpbxDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColTipoIden;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColNombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gpbxDatosGenerales;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFechaInicio;
        private System.Windows.Forms.TextBox TxtTrabajador;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.TextBox TxtFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}