namespace SeguimientoEmpresa.Formularios
{
    partial class formTrabajador
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
            this.DgTrabajador = new System.Windows.Forms.DataGridView();
            this.gpbxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.CboTipoIde = new System.Windows.Forms.ComboBox();
            this.CboGenero = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProfesion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRedSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNivelEducativo = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.TxtPirmerNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCURP = new System.Windows.Forms.Label();
            this.gpbxFotografia = new System.Windows.Forms.GroupBox();
            this.btnCargarF = new System.Windows.Forms.Button();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.ventdialogArchivos = new System.Windows.Forms.OpenFileDialog();
            this.DgTrabajadorColIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTrabajadorColNombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTrabajadorColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgTrabajador)).BeginInit();
            this.gpbxDatosGenerales.SuspendLayout();
            this.gpbxFotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // DgTrabajador
            // 
            this.DgTrabajador.AllowUserToAddRows = false;
            this.DgTrabajador.BackgroundColor = System.Drawing.Color.White;
            this.DgTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgTrabajador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgTrabajadorColIdentificacion,
            this.DgTrabajadorColNombre1,
            this.DgTrabajadorColTelefono});
            this.DgTrabajador.EnableHeadersVisualStyles = false;
            this.DgTrabajador.Location = new System.Drawing.Point(12, 404);
            this.DgTrabajador.MultiSelect = false;
            this.DgTrabajador.Name = "DgTrabajador";
            this.DgTrabajador.ReadOnly = true;
            this.DgTrabajador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgTrabajador.RowHeadersVisible = false;
            this.DgTrabajador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgTrabajador.Size = new System.Drawing.Size(636, 232);
            this.DgTrabajador.TabIndex = 0;
            this.DgTrabajador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrabajador_CellClick);
            // 
            // gpbxDatosGenerales
            // 
            this.gpbxDatosGenerales.BackColor = System.Drawing.Color.White;
            this.gpbxDatosGenerales.Controls.Add(this.CboTipoIde);
            this.gpbxDatosGenerales.Controls.Add(this.gpbxFotografia);
            this.gpbxDatosGenerales.Controls.Add(this.CboGenero);
            this.gpbxDatosGenerales.Controls.Add(this.TxtEmail);
            this.gpbxDatosGenerales.Controls.Add(this.label6);
            this.gpbxDatosGenerales.Controls.Add(this.label5);
            this.gpbxDatosGenerales.Controls.Add(this.TxtPrimerApellido);
            this.gpbxDatosGenerales.Controls.Add(this.label4);
            this.gpbxDatosGenerales.Controls.Add(this.TxtSegundoApellido);
            this.gpbxDatosGenerales.Controls.Add(this.label3);
            this.gpbxDatosGenerales.Controls.Add(this.TxtProfesion);
            this.gpbxDatosGenerales.Controls.Add(this.label2);
            this.gpbxDatosGenerales.Controls.Add(this.TxtRedSocial);
            this.gpbxDatosGenerales.Controls.Add(this.label1);
            this.gpbxDatosGenerales.Controls.Add(this.TxtTelefono);
            this.gpbxDatosGenerales.Controls.Add(this.lblPuesto);
            this.gpbxDatosGenerales.Controls.Add(this.TxtDireccion);
            this.gpbxDatosGenerales.Controls.Add(this.TxtNivelEducativo);
            this.gpbxDatosGenerales.Controls.Add(this.lblCelular);
            this.gpbxDatosGenerales.Controls.Add(this.lblEmail);
            this.gpbxDatosGenerales.Controls.Add(this.cmbFechaNac);
            this.gpbxDatosGenerales.Controls.Add(this.TxtSegundoNombre);
            this.gpbxDatosGenerales.Controls.Add(this.TxtPirmerNombre);
            this.gpbxDatosGenerales.Controls.Add(this.TxtIdentificacion);
            this.gpbxDatosGenerales.Controls.Add(this.lblFechaNac);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoMaterno);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoPaterno);
            this.gpbxDatosGenerales.Controls.Add(this.lblNombre);
            this.gpbxDatosGenerales.Controls.Add(this.lblCURP);
            this.gpbxDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxDatosGenerales.Location = new System.Drawing.Point(12, 73);
            this.gpbxDatosGenerales.Name = "gpbxDatosGenerales";
            this.gpbxDatosGenerales.Size = new System.Drawing.Size(1211, 308);
            this.gpbxDatosGenerales.TabIndex = 14;
            this.gpbxDatosGenerales.TabStop = false;
            this.gpbxDatosGenerales.Text = "Datos Generales";
            // 
            // CboTipoIde
            // 
            this.CboTipoIde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoIde.FormattingEnabled = true;
            this.CboTipoIde.Location = new System.Drawing.Point(18, 33);
            this.CboTipoIde.Name = "CboTipoIde";
            this.CboTipoIde.Size = new System.Drawing.Size(194, 25);
            this.CboTipoIde.TabIndex = 34;
            // 
            // CboGenero
            // 
            this.CboGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboGenero.FormattingEnabled = true;
            this.CboGenero.Location = new System.Drawing.Point(589, 99);
            this.CboGenero.Name = "CboGenero";
            this.CboGenero.Size = new System.Drawing.Size(194, 25);
            this.CboGenero.TabIndex = 33;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(442, 175);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(194, 26);
            this.TxtEmail.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Genero";
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerApellido.Location = new System.Drawing.Point(18, 98);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(194, 26);
            this.TxtPrimerApellido.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Primer Apellido";
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoApellido.Location = new System.Drawing.Point(225, 98);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(194, 26);
            this.TxtSegundoApellido.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Segundo Apellido";
            // 
            // TxtProfesion
            // 
            this.TxtProfesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProfesion.Location = new System.Drawing.Point(227, 175);
            this.TxtProfesion.Name = "TxtProfesion";
            this.TxtProfesion.Size = new System.Drawing.Size(194, 26);
            this.TxtProfesion.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Profesión:";
            // 
            // TxtRedSocial
            // 
            this.TxtRedSocial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRedSocial.Location = new System.Drawing.Point(18, 241);
            this.TxtRedSocial.Name = "TxtRedSocial";
            this.TxtRedSocial.Size = new System.Drawing.Size(194, 26);
            this.TxtRedSocial.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Red Social:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(18, 175);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(194, 26);
            this.TxtTelefono.TabIndex = 20;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(14, 202);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(75, 20);
            this.lblPuesto.TabIndex = 18;
            this.lblPuesto.Text = "Teléfono:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(408, 241);
            this.TxtDireccion.MaxLength = 11;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(376, 26);
            this.TxtDireccion.TabIndex = 15;
            // 
            // TxtNivelEducativo
            // 
            this.TxtNivelEducativo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNivelEducativo.Location = new System.Drawing.Point(225, 241);
            this.TxtNivelEducativo.Name = "TxtNivelEducativo";
            this.TxtNivelEducativo.Size = new System.Drawing.Size(165, 26);
            this.TxtNivelEducativo.TabIndex = 14;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(404, 270);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(84, 20);
            this.lblCelular.TabIndex = 13;
            this.lblCelular.Text = "Dirección:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(221, 270);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(125, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Nivel Educativo";
            // 
            // cmbFechaNac
            // 
            this.cmbFechaNac.CustomFormat = "dd-MM-yyyy";
            this.cmbFechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbFechaNac.Location = new System.Drawing.Point(425, 98);
            this.cmbFechaNac.Name = "cmbFechaNac";
            this.cmbFechaNac.Size = new System.Drawing.Size(129, 26);
            this.cmbFechaNac.TabIndex = 11;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoNombre.Location = new System.Drawing.Point(590, 33);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(194, 26);
            this.TxtSegundoNombre.TabIndex = 9;
            // 
            // TxtPirmerNombre
            // 
            this.TxtPirmerNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPirmerNombre.Location = new System.Drawing.Point(387, 33);
            this.TxtPirmerNombre.Name = "TxtPirmerNombre";
            this.TxtPirmerNombre.Size = new System.Drawing.Size(194, 26);
            this.TxtPirmerNombre.TabIndex = 8;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(229, 33);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(149, 26);
            this.TxtIdentificacion.TabIndex = 7;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(421, 127);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(169, 20);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha de nacimiento:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(586, 62);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(141, 20);
            this.lblApellidoMaterno.TabIndex = 4;
            this.lblApellidoMaterno.Text = "Segundo Nombre:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(383, 62);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(121, 20);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Primer Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(225, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Identificación:";
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Location = new System.Drawing.Point(14, 62);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(147, 20);
            this.lblCURP.TabIndex = 1;
            this.lblCURP.Text = "Tipo Identificacion:";
            // 
            // gpbxFotografia
            // 
            this.gpbxFotografia.BackColor = System.Drawing.Color.White;
            this.gpbxFotografia.Controls.Add(this.btnCargarF);
            this.gpbxFotografia.Controls.Add(this.pbxFotografia);
            this.gpbxFotografia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxFotografia.Location = new System.Drawing.Point(889, 33);
            this.gpbxFotografia.Name = "gpbxFotografia";
            this.gpbxFotografia.Size = new System.Drawing.Size(281, 209);
            this.gpbxFotografia.TabIndex = 15;
            this.gpbxFotografia.TabStop = false;
            this.gpbxFotografia.Text = "Fotografía";
            // 
            // btnCargarF
            // 
            this.btnCargarF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarF.Location = new System.Drawing.Point(173, 161);
            this.btnCargarF.Name = "btnCargarF";
            this.btnCargarF.Size = new System.Drawing.Size(102, 30);
            this.btnCargarF.TabIndex = 26;
            this.btnCargarF.Text = "Cargar Foto";
            this.btnCargarF.UseVisualStyleBackColor = true;
            this.btnCargarF.Click += new System.EventHandler(this.btnCargarF_Click);
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.InitialImage = null;
            this.pbxFotografia.Location = new System.Drawing.Point(10, 26);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(143, 161);
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotografia.TabIndex = 0;
            this.pbxFotografia.TabStop = false;
            // 
            // ventdialogArchivos
            // 
            this.ventdialogArchivos.FileName = "openFileDialog1";
            // 
            // DgTrabajadorColIdentificacion
            // 
            this.DgTrabajadorColIdentificacion.HeaderText = "Identificacion";
            this.DgTrabajadorColIdentificacion.Name = "DgTrabajadorColIdentificacion";
            this.DgTrabajadorColIdentificacion.ReadOnly = true;
            this.DgTrabajadorColIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgTrabajadorColIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgTrabajadorColIdentificacion.Width = 150;
            // 
            // DgTrabajadorColNombre1
            // 
            this.DgTrabajadorColNombre1.HeaderText = "Nombres";
            this.DgTrabajadorColNombre1.Name = "DgTrabajadorColNombre1";
            this.DgTrabajadorColNombre1.ReadOnly = true;
            this.DgTrabajadorColNombre1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgTrabajadorColNombre1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgTrabajadorColNombre1.Width = 350;
            // 
            // DgTrabajadorColTelefono
            // 
            this.DgTrabajadorColTelefono.HeaderText = "Teléfono";
            this.DgTrabajadorColTelefono.Name = "DgTrabajadorColTelefono";
            this.DgTrabajadorColTelefono.ReadOnly = true;
            this.DgTrabajadorColTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgTrabajadorColTelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgTrabajadorColTelefono.Width = 120;
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
            this.btnAceptar.Location = new System.Drawing.Point(795, 463);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Rotation = 0D;
            this.btnAceptar.Size = new System.Drawing.Size(142, 52);
            this.btnAceptar.TabIndex = 46;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
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
            this.BtnCancelar.Location = new System.Drawing.Point(974, 463);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Rotation = 0D;
            this.BtnCancelar.Size = new System.Drawing.Size(156, 52);
            this.BtnCancelar.TabIndex = 47;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // formTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 664);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbxDatosGenerales);
            this.Controls.Add(this.DgTrabajador);
            this.Name = "formTrabajador";
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.formTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgTrabajador)).EndInit();
            this.gpbxDatosGenerales.ResumeLayout(false);
            this.gpbxDatosGenerales.PerformLayout();
            this.gpbxFotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgTrabajador;
        private System.Windows.Forms.GroupBox gpbxDatosGenerales;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProfesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRedSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNivelEducativo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker cmbFechaNac;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox TxtPirmerNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.GroupBox gpbxFotografia;
        private System.Windows.Forms.Button btnCargarF;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboGenero;
        private System.Windows.Forms.ComboBox CboTipoIde;
        private System.Windows.Forms.OpenFileDialog ventdialogArchivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColNombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColTelefono;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
    }
}