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
            this.DgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColFechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumeroContrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.DtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTrabajador = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblCURP = new System.Windows.Forms.Label();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.DgvDetalleColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDetalleColMotivo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DgvDetalleColResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).BeginInit();
            this.gpbxDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEmpresa
            // 
            this.DgvEmpresa.AllowUserToAddRows = false;
            this.DgvEmpresa.AllowUserToDeleteRows = false;
            this.DgvEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.DgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvColId,
            this.DgvColNumero,
            this.DgvColTrabajador,
            this.DgvColIdentificacion,
            this.DgvColFechaInicio,
            this.DgvColFechaFinal,
            this.DgvColEstado});
            this.DgvEmpresa.EnableHeadersVisualStyles = false;
            this.DgvEmpresa.Location = new System.Drawing.Point(18, 335);
            this.DgvEmpresa.MultiSelect = false;
            this.DgvEmpresa.Name = "DgvEmpresa";
            this.DgvEmpresa.ReadOnly = true;
            this.DgvEmpresa.RowHeadersVisible = false;
            this.DgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresa.Size = new System.Drawing.Size(630, 352);
            this.DgvEmpresa.TabIndex = 10;
            this.DgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresa_CellClick);
            // 
            // DgvColId
            // 
            this.DgvColId.HeaderText = "Id";
            this.DgvColId.Name = "DgvColId";
            this.DgvColId.ReadOnly = true;
            this.DgvColId.Visible = false;
            // 
            // DgvColNumero
            // 
            this.DgvColNumero.HeaderText = "Numero";
            this.DgvColNumero.Name = "DgvColNumero";
            this.DgvColNumero.ReadOnly = true;
            this.DgvColNumero.Width = 70;
            // 
            // DgvColTrabajador
            // 
            this.DgvColTrabajador.HeaderText = "Trabajador";
            this.DgvColTrabajador.Name = "DgvColTrabajador";
            this.DgvColTrabajador.ReadOnly = true;
            this.DgvColTrabajador.Width = 250;
            // 
            // DgvColIdentificacion
            // 
            this.DgvColIdentificacion.HeaderText = "Identificacion";
            this.DgvColIdentificacion.Name = "DgvColIdentificacion";
            this.DgvColIdentificacion.ReadOnly = true;
            this.DgvColIdentificacion.Visible = false;
            // 
            // DgvColFechaInicio
            // 
            this.DgvColFechaInicio.HeaderText = "Fecha Inicio";
            this.DgvColFechaInicio.Name = "DgvColFechaInicio";
            this.DgvColFechaInicio.ReadOnly = true;
            // 
            // DgvColFechaFinal
            // 
            this.DgvColFechaFinal.HeaderText = "Fecha Final";
            this.DgvColFechaFinal.Name = "DgvColFechaFinal";
            this.DgvColFechaFinal.ReadOnly = true;
            // 
            // DgvColEstado
            // 
            this.DgvColEstado.HeaderText = "Estado";
            this.DgvColEstado.Name = "DgvColEstado";
            this.DgvColEstado.ReadOnly = true;
            // 
            // gpbxDatosGenerales
            // 
            this.gpbxDatosGenerales.BackColor = System.Drawing.Color.White;
            this.gpbxDatosGenerales.Controls.Add(this.label5);
            this.gpbxDatosGenerales.Controls.Add(this.TxtNumeroContrato);
            this.gpbxDatosGenerales.Controls.Add(this.label3);
            this.gpbxDatosGenerales.Controls.Add(this.CboEstado);
            this.gpbxDatosGenerales.Controls.Add(this.DtFechaFinal);
            this.gpbxDatosGenerales.Controls.Add(this.DtFechaInicio);
            this.gpbxDatosGenerales.Controls.Add(this.TxtIdentificacion);
            this.gpbxDatosGenerales.Controls.Add(this.label2);
            this.gpbxDatosGenerales.Controls.Add(this.label1);
            this.gpbxDatosGenerales.Controls.Add(this.TxtDescripcion);
            this.gpbxDatosGenerales.Controls.Add(this.label4);
            this.gpbxDatosGenerales.Controls.Add(this.TxtTrabajador);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoPaterno);
            this.gpbxDatosGenerales.Controls.Add(this.lblCURP);
            this.gpbxDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxDatosGenerales.Location = new System.Drawing.Point(18, 79);
            this.gpbxDatosGenerales.Name = "gpbxDatosGenerales";
            this.gpbxDatosGenerales.Size = new System.Drawing.Size(1346, 174);
            this.gpbxDatosGenerales.TabIndex = 0;
            this.gpbxDatosGenerales.TabStop = false;
            this.gpbxDatosGenerales.Text = "Datos Generales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nombres";
            // 
            // TxtNumeroContrato
            // 
            this.TxtNumeroContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumeroContrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroContrato.Location = new System.Drawing.Point(985, 29);
            this.TxtNumeroContrato.MaxLength = 18;
            this.TxtNumeroContrato.Name = "TxtNumeroContrato";
            this.TxtNumeroContrato.Size = new System.Drawing.Size(123, 26);
            this.TxtNumeroContrato.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(981, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Numero Contrato";
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.Enabled = false;
            this.CboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(813, 29);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(158, 29);
            this.CboEstado.TabIndex = 3;
            // 
            // DtFechaFinal
            // 
            this.DtFechaFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaFinal.Location = new System.Drawing.Point(667, 29);
            this.DtFechaFinal.Name = "DtFechaFinal";
            this.DtFechaFinal.Size = new System.Drawing.Size(132, 27);
            this.DtFechaFinal.TabIndex = 2;
            // 
            // DtFechaInicio
            // 
            this.DtFechaInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaInicio.Location = new System.Drawing.Point(535, 29);
            this.DtFechaInicio.Name = "DtFechaInicio";
            this.DtFechaInicio.Size = new System.Drawing.Size(126, 27);
            this.DtFechaInicio.TabIndex = 1;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(17, 29);
            this.TxtIdentificacion.MaxLength = 18;
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(165, 26);
            this.TxtIdentificacion.TabIndex = 0;
            this.TxtIdentificacion.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            this.TxtIdentificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdentificacion_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(809, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha Final";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(17, 92);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(1091, 48);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Descripción";
            // 
            // TxtTrabajador
            // 
            this.TxtTrabajador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTrabajador.Enabled = false;
            this.TxtTrabajador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTrabajador.Location = new System.Drawing.Point(188, 29);
            this.TxtTrabajador.MaxLength = 18;
            this.TxtTrabajador.Name = "TxtTrabajador";
            this.TxtTrabajador.Size = new System.Drawing.Size(341, 26);
            this.TxtTrabajador.TabIndex = 10;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(531, 60);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(99, 20);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Fecha Inicio";
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Location = new System.Drawing.Point(13, 60);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(111, 20);
            this.lblCURP.TabIndex = 1;
            this.lblCURP.Text = "Identificación";
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.DgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvDetalleColDescripcion,
            this.DgvDetalleColMotivo,
            this.DgvDetalleColResultado});
            this.DgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvDetalle.EnableHeadersVisualStyles = false;
            this.DgvDetalle.Location = new System.Drawing.Point(654, 335);
            this.DgvDetalle.MultiSelect = false;
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.RowHeadersVisible = false;
            this.DgvDetalle.RowHeadersWidth = 43;
            this.DgvDetalle.Size = new System.Drawing.Size(720, 326);
            this.DgvDetalle.TabIndex = 16;
            // 
            // DgvDetalleColDescripcion
            // 
            this.DgvDetalleColDescripcion.HeaderText = "Descripcion";
            this.DgvDetalleColDescripcion.Name = "DgvDetalleColDescripcion";
            this.DgvDetalleColDescripcion.Width = 300;
            // 
            // DgvDetalleColMotivo
            // 
            this.DgvDetalleColMotivo.HeaderText = "Motivo";
            this.DgvDetalleColMotivo.Name = "DgvDetalleColMotivo";
            this.DgvDetalleColMotivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalleColMotivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DgvDetalleColMotivo.Width = 160;
            // 
            // DgvDetalleColResultado
            // 
            this.DgvDetalleColResultado.HeaderText = "Resultado";
            this.DgvDetalleColResultado.Name = "DgvDetalleColResultado";
            this.DgvDetalleColResultado.Width = 250;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.FirefoxBrowser;
            this.btnAceptar.IconColor = System.Drawing.Color.Black;
            this.btnAceptar.IconSize = 40;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(125, 269);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Rotation = 0D;
            this.btnAceptar.Size = new System.Drawing.Size(151, 52);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.BtnNuevo.IconColor = System.Drawing.Color.Black;
            this.BtnNuevo.IconSize = 40;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(428, 269);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Padding = new System.Windows.Forms.Padding(5);
            this.BtnNuevo.Rotation = 0D;
            this.BtnNuevo.Size = new System.Drawing.Size(128, 52);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Visible = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelar.IconColor = System.Drawing.Color.Black;
            this.BtnCancelar.IconSize = 40;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(282, 269);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Rotation = 0D;
            this.BtnCancelar.Size = new System.Drawing.Size(140, 52);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // formContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 699);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DgvDetalle);
            this.Controls.Add(this.gpbxDatosGenerales);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.DgvEmpresa);
            this.Controls.Add(this.btnAceptar);
            this.Name = "formContrato";
            this.Text = "Contratos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).EndInit();
            this.gpbxDatosGenerales.ResumeLayout(false);
            this.gpbxDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmpresa;
        private System.Windows.Forms.GroupBox gpbxDatosGenerales;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTrabajador;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.DateTimePicker DtFechaFinal;
        private System.Windows.Forms.DateTimePicker DtFechaInicio;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.TextBox TxtNumeroContrato;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColFechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColEstado;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDetalleColDescripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn DgvDetalleColMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDetalleColResultado;
    }
}