namespace SeguimientoEmpresa.Formularios
{
    partial class formDetalleAnotaciones
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
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.DgvDetalleColResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDetalleColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDetalleColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.DgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvDetalleColResultado,
            this.DgvDetalleColFecha,
            this.DgvDetalleColDescripcion});
            this.DgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvDetalle.EnableHeadersVisualStyles = false;
            this.DgvDetalle.Location = new System.Drawing.Point(12, 118);
            this.DgvDetalle.MultiSelect = false;
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.ReadOnly = true;
            this.DgvDetalle.RowHeadersVisible = false;
            this.DgvDetalle.RowHeadersWidth = 43;
            this.DgvDetalle.Size = new System.Drawing.Size(818, 393);
            this.DgvDetalle.TabIndex = 17;
            // 
            // DgvDetalleColResultado
            // 
            this.DgvDetalleColResultado.HeaderText = "# de contrato";
            this.DgvDetalleColResultado.Name = "DgvDetalleColResultado";
            this.DgvDetalleColResultado.ReadOnly = true;
            // 
            // DgvDetalleColFecha
            // 
            this.DgvDetalleColFecha.HeaderText = "Fecha";
            this.DgvDetalleColFecha.Name = "DgvDetalleColFecha";
            this.DgvDetalleColFecha.ReadOnly = true;
            // 
            // DgvDetalleColDescripcion
            // 
            this.DgvDetalleColDescripcion.HeaderText = "Descripcion";
            this.DgvDetalleColDescripcion.Name = "DgvDetalleColDescripcion";
            this.DgvDetalleColDescripcion.ReadOnly = true;
            this.DgvDetalleColDescripcion.Width = 600;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 33);
            this.label6.TabIndex = 29;
            this.label6.Text = "Anotaciones";
            // 
            // formDetalleAnotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvDetalle);
            this.Name = "formDetalleAnotaciones";
            this.Load += new System.EventHandler(this.formDetalleAnotaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDetalleColResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDetalleColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDetalleColDescripcion;
        private System.Windows.Forms.Label label6;
    }
}