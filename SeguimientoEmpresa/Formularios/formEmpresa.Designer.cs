namespace SeguimientoEmpresa.Formularios
{
    partial class formEmpresa
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
            this.gpbxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.TxtTelRepresentante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRepresentante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TxtPaginaWeb = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.dfgdf = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCURP = new System.Windows.Forms.Label();
            this.gpbxFotografia = new System.Windows.Forms.GroupBox();
            this.btnCargarFoto = new FontAwesome.Sharp.IconButton();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.ventdialogArchivos = new System.Windows.Forms.OpenFileDialog();
            this.DgvEmpresa = new System.Windows.Forms.DataGridView();
            this.DgTrabajadorColTipoIden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTrabajadorColNombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnTrabajador = new FontAwesome.Sharp.IconButton();
            this.BtnContrato = new FontAwesome.Sharp.IconButton();
            this.gpbxDatosGenerales.SuspendLayout();
            this.gpbxFotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbxDatosGenerales
            // 
            this.gpbxDatosGenerales.BackColor = System.Drawing.Color.White;
            this.gpbxDatosGenerales.Controls.Add(this.TxtTelRepresentante);
            this.gpbxDatosGenerales.Controls.Add(this.label2);
            this.gpbxDatosGenerales.Controls.Add(this.TxtRepresentante);
            this.gpbxDatosGenerales.Controls.Add(this.label1);
            this.gpbxDatosGenerales.Controls.Add(this.TxtDireccion);
            this.gpbxDatosGenerales.Controls.Add(this.lblPuesto);
            this.gpbxDatosGenerales.Controls.Add(this.txtEmail);
            this.gpbxDatosGenerales.Controls.Add(this.lblEmail);
            this.gpbxDatosGenerales.Controls.Add(this.TxtPaginaWeb);
            this.gpbxDatosGenerales.Controls.Add(this.TxtTelefono);
            this.gpbxDatosGenerales.Controls.Add(this.TxtRazonSocial);
            this.gpbxDatosGenerales.Controls.Add(this.TxtNit);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoMaterno);
            this.gpbxDatosGenerales.Controls.Add(this.dfgdf);
            this.gpbxDatosGenerales.Controls.Add(this.lblNombre);
            this.gpbxDatosGenerales.Controls.Add(this.lblCURP);
            this.gpbxDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxDatosGenerales.Location = new System.Drawing.Point(21, 81);
            this.gpbxDatosGenerales.Name = "gpbxDatosGenerales";
            this.gpbxDatosGenerales.Size = new System.Drawing.Size(735, 257);
            this.gpbxDatosGenerales.TabIndex = 1;
            this.gpbxDatosGenerales.TabStop = false;
            this.gpbxDatosGenerales.Text = "Datos Generales";
            this.gpbxDatosGenerales.Enter += new System.EventHandler(this.gpbxDatosGenerales_Enter);
            // 
            // TxtTelRepresentante
            // 
            this.TxtTelRepresentante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelRepresentante.Location = new System.Drawing.Point(497, 178);
            this.TxtTelRepresentante.MaxLength = 10;
            this.TxtTelRepresentante.Name = "TxtTelRepresentante";
            this.TxtTelRepresentante.Size = new System.Drawing.Size(162, 26);
            this.TxtTelRepresentante.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tel Rep. Legal:";
            // 
            // TxtRepresentante
            // 
            this.TxtRepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRepresentante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepresentante.Location = new System.Drawing.Point(26, 178);
            this.TxtRepresentante.MaxLength = 70;
            this.TxtRepresentante.Name = "TxtRepresentante";
            this.TxtRepresentante.Size = new System.Drawing.Size(447, 26);
            this.TxtRepresentante.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Representante Legal:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(497, 117);
            this.TxtDireccion.MaxLength = 200;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(226, 26);
            this.TxtDireccion.TabIndex = 5;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(493, 146);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(84, 20);
            this.lblPuesto.TabIndex = 18;
            this.lblPuesto.Text = "Direccion:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(26, 117);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(242, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(99, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Pagina Web";
            // 
            // TxtPaginaWeb
            // 
            this.TxtPaginaWeb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaginaWeb.Location = new System.Drawing.Point(246, 117);
            this.TxtPaginaWeb.MaxLength = 200;
            this.TxtPaginaWeb.Name = "TxtPaginaWeb";
            this.TxtPaginaWeb.Size = new System.Drawing.Size(227, 26);
            this.TxtPaginaWeb.TabIndex = 4;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(602, 46);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(121, 26);
            this.TxtTelefono.TabIndex = 2;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(199, 49);
            this.TxtRazonSocial.MaxLength = 60;
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(381, 26);
            this.TxtRazonSocial.TabIndex = 1;
            // 
            // TxtNit
            // 
            this.TxtNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit.Location = new System.Drawing.Point(26, 49);
            this.TxtNit.MaxLength = 10;
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(161, 26);
            this.TxtNit.TabIndex = 0;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(22, 146);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(50, 20);
            this.lblApellidoMaterno.TabIndex = 4;
            this.lblApellidoMaterno.Text = "Email:";
            // 
            // dfgdf
            // 
            this.dfgdf.AutoSize = true;
            this.dfgdf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfgdf.Location = new System.Drawing.Point(598, 75);
            this.dfgdf.Name = "dfgdf";
            this.dfgdf.Size = new System.Drawing.Size(75, 20);
            this.dfgdf.TabIndex = 3;
            this.dfgdf.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(195, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Razon Social:";
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Location = new System.Drawing.Point(22, 78);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(32, 20);
            this.lblCURP.TabIndex = 1;
            this.lblCURP.Text = "Nit:";
            // 
            // gpbxFotografia
            // 
            this.gpbxFotografia.BackColor = System.Drawing.Color.White;
            this.gpbxFotografia.Controls.Add(this.btnCargarFoto);
            this.gpbxFotografia.Controls.Add(this.pbxFotografia);
            this.gpbxFotografia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxFotografia.Location = new System.Drawing.Point(762, 81);
            this.gpbxFotografia.Name = "gpbxFotografia";
            this.gpbxFotografia.Size = new System.Drawing.Size(405, 257);
            this.gpbxFotografia.TabIndex = 6;
            this.gpbxFotografia.TabStop = false;
            this.gpbxFotografia.Text = "Fotografía";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCargarFoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFoto.IconChar = FontAwesome.Sharp.IconChar.FirefoxBrowser;
            this.btnCargarFoto.IconColor = System.Drawing.Color.Black;
            this.btnCargarFoto.IconSize = 30;
            this.btnCargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarFoto.Location = new System.Drawing.Point(273, 182);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Padding = new System.Windows.Forms.Padding(5);
            this.btnCargarFoto.Rotation = 0D;
            this.btnCargarFoto.Size = new System.Drawing.Size(126, 52);
            this.btnCargarFoto.TabIndex = 47;
            this.btnCargarFoto.Text = "Cargar";
            this.btnCargarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxFotografia.InitialImage = null;
            this.pbxFotografia.Location = new System.Drawing.Point(25, 38);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(242, 194);
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotografia.TabIndex = 0;
            this.pbxFotografia.TabStop = false;
            // 
            // ventdialogArchivos
            // 
            this.ventdialogArchivos.FileName = "openFileDialog1";
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
            this.DgTrabajadorColTipoIden,
            this.DgTrabajadorColNombre1});
            this.DgvEmpresa.EnableHeadersVisualStyles = false;
            this.DgvEmpresa.Location = new System.Drawing.Point(37, 429);
            this.DgvEmpresa.MultiSelect = false;
            this.DgvEmpresa.Name = "DgvEmpresa";
            this.DgvEmpresa.ReadOnly = true;
            this.DgvEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvEmpresa.RowHeadersVisible = false;
            this.DgvEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresa.Size = new System.Drawing.Size(614, 173);
            this.DgvEmpresa.TabIndex = 9;
            this.DgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresa_CellClick);
            // 
            // DgTrabajadorColTipoIden
            // 
            this.DgTrabajadorColTipoIden.HeaderText = "Nit";
            this.DgTrabajadorColTipoIden.Name = "DgTrabajadorColTipoIden";
            this.DgTrabajadorColTipoIden.ReadOnly = true;
            this.DgTrabajadorColTipoIden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgTrabajadorColTipoIden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgTrabajadorColNombre1
            // 
            this.DgTrabajadorColNombre1.HeaderText = "Razon Social";
            this.DgTrabajadorColNombre1.Name = "DgTrabajadorColNombre1";
            this.DgTrabajadorColNombre1.ReadOnly = true;
            this.DgTrabajadorColNombre1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgTrabajadorColNombre1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgTrabajadorColNombre1.Width = 500;
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
            this.btnAceptar.Location = new System.Drawing.Point(178, 353);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Rotation = 0D;
            this.btnAceptar.Size = new System.Drawing.Size(142, 52);
            this.btnAceptar.TabIndex = 43;
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
            this.BtnCancelar.Location = new System.Drawing.Point(753, 353);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Rotation = 0D;
            this.BtnCancelar.Size = new System.Drawing.Size(156, 52);
            this.BtnCancelar.TabIndex = 44;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnTrabajador
            // 
            this.BtnTrabajador.Enabled = false;
            this.BtnTrabajador.FlatAppearance.BorderSize = 0;
            this.BtnTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrabajador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTrabajador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrabajador.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.BtnTrabajador.IconColor = System.Drawing.Color.Black;
            this.BtnTrabajador.IconSize = 40;
            this.BtnTrabajador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrabajador.Location = new System.Drawing.Point(350, 353);
            this.BtnTrabajador.Name = "BtnTrabajador";
            this.BtnTrabajador.Padding = new System.Windows.Forms.Padding(5);
            this.BtnTrabajador.Rotation = 0D;
            this.BtnTrabajador.Size = new System.Drawing.Size(177, 52);
            this.BtnTrabajador.TabIndex = 45;
            this.BtnTrabajador.Text = "Trabajadores";
            this.BtnTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTrabajador.UseVisualStyleBackColor = true;
            this.BtnTrabajador.Click += new System.EventHandler(this.BtnTrabajador_Click);
            // 
            // BtnContrato
            // 
            this.BtnContrato.Enabled = false;
            this.BtnContrato.FlatAppearance.BorderSize = 0;
            this.BtnContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContrato.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContrato.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.BtnContrato.IconColor = System.Drawing.Color.Black;
            this.BtnContrato.IconSize = 40;
            this.BtnContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContrato.Location = new System.Drawing.Point(568, 353);
            this.BtnContrato.Name = "BtnContrato";
            this.BtnContrato.Padding = new System.Windows.Forms.Padding(5);
            this.BtnContrato.Rotation = 0D;
            this.BtnContrato.Size = new System.Drawing.Size(167, 52);
            this.BtnContrato.TabIndex = 46;
            this.BtnContrato.Text = "Contratos";
            this.BtnContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContrato.UseVisualStyleBackColor = true;
            this.BtnContrato.Click += new System.EventHandler(this.BtnContrato_Click_1);
            // 
            // formEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 623);
            this.Controls.Add(this.BtnContrato);
            this.Controls.Add(this.BtnTrabajador);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.DgvEmpresa);
            this.Controls.Add(this.gpbxFotografia);
            this.Controls.Add(this.gpbxDatosGenerales);
            this.Name = "formEmpresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.formEmpresa_Load);
            this.gpbxDatosGenerales.ResumeLayout(false);
            this.gpbxDatosGenerales.PerformLayout();
            this.gpbxFotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDatosGenerales;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TxtPaginaWeb;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.TextBox TxtNit;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label dfgdf;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.GroupBox gpbxFotografia;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.TextBox TxtRepresentante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTelRepresentante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ventdialogArchivos;
        private System.Windows.Forms.DataGridView DgvEmpresa;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnTrabajador;
        private FontAwesome.Sharp.IconButton BtnContrato;
        private FontAwesome.Sharp.IconButton btnCargarFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColTipoIden;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTrabajadorColNombre1;
    }
}