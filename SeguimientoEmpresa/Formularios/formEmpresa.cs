using MaterialSkin.Controls;
using SeguimientoEmpresa.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoEmpresa.Formularios
{
    public partial class formEmpresa : MaterialForm
    {
        public formEmpresa()
        {
            InitializeComponent();
        }

        async Task LoadEmpresa()
        {
            DgvEmpresa.Rows.Clear();
            var empresas = await BD.seguimiento_Empresa_Entity.Empresa.ToListAsync();
            foreach (var item in empresas)
            {
                DgvEmpresa.Rows.Add(item.emp_nit, item.emp_razonSocial);
            }
        }
        private async void formEmpresa_Load(object sender, EventArgs e)
        {
            btnAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            BtnTrabajador.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            btnCargarFoto.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            BtnContrato.IconChar = FontAwesome.Sharp.IconChar.FileContract;


            await LoadEmpresa();
            DgvEmpresa.ClearSelection();

            DgvEmpresa.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16, GraphicsUnit.World);
            foreach (DataGridViewColumn c in DgvEmpresa.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Century Gothic", 15, GraphicsUnit.World);
            }
            DgvEmpresa.EnableHeadersVisualStyles = false;
        }

        async Task DatosEmpresa(string nit)
        {
            var empresa = await BD.seguimiento_Empresa_Entity.Empresa.FirstOrDefaultAsync(s => s.emp_nit == nit);
            if (empresa == null)
            {
                MessageBox.Show("Sin resultados");
                return;
            }
            BtnContrato.Enabled = true;
            BtnTrabajador.Enabled = true;
            TxtDireccion.Text = empresa.emp_direccion;
            txtEmail.Text = empresa.emp_email;
            TxtNit.Text = empresa.emp_nit;
            TxtPaginaWeb.Text = empresa.emp_paginaWeb;
            TxtRazonSocial.Text = empresa.emp_razonSocial;
            TxtRepresentante.Text = empresa.emp_representanteLegar;
            TxtTelefono.Text = empresa.emp_telefono;
            TxtTelRepresentante.Text = empresa.emp_telefonoRepresentante;
            pbxFotografia.Image = null;

            if (empresa.emp_foto1 != null)
            {
                MemoryStream ms = new MemoryStream(empresa.emp_foto1);
                pbxFotografia.Image = Image.FromStream(ms);
            }

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void gpbxDatosGenerales_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargarF_Click(object sender, EventArgs e)
        {

        }

        private void BtnTrabajadores_Click(object sender, EventArgs e)
        {

        }

        private async void DgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                var nit = DgvEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
                await DatosEmpresa(nit);
            }
        }

        private void BtnContrato_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            var empresa = new Empresa();

            #region VALIDACIONES
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Ingrese un nit", "Nit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAceptar.UseWaitCursor = false;
                return;
            }
            if (string.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                MessageBox.Show("Ingrese una razon social", "Razon social", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAceptar.UseWaitCursor = false;
                return;
            }

            if (string.IsNullOrEmpty(TxtRepresentante.Text))
            {
                MessageBox.Show("Ingrese una representante lega", "Representante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAceptar.UseWaitCursor = false;
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Ingrese un email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAceptar.UseWaitCursor = false;
                return;
            }
            if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
            {
                MessageBox.Show("Ingrese una dirección", "Direccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAceptar.UseWaitCursor = false;
                return;
            }
            #endregion

            //try
            //{

            if (MessageBox.Show("¿Esta seguro de continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                btnAceptar.UseWaitCursor = false;
                return;

            }

            btnAceptar.UseWaitCursor = true;
            await Task.Delay(1000);
            string proceso;
            btnAceptar.Enabled = false;
            empresa.emp_direccion = TxtDireccion.Text.Trim();
            empresa.emp_email = txtEmail.Text.Trim();
            empresa.emp_nit = TxtNit.Text.Trim();
            empresa.emp_paginaWeb = TxtPaginaWeb.Text.Trim();
            empresa.emp_razonSocial = TxtRazonSocial.Text.Trim();
            empresa.emp_representanteLegar = TxtRepresentante.Text.Trim();
            empresa.emp_telefono = TxtTelefono.Text.Trim();
            empresa.emp_telefonoRepresentante = TxtTelRepresentante.Text.Trim();

            if (pbxFotografia.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbxFotografia.Image.Save(ms, ImageFormat.Jpeg);
                byte[] foto = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(foto, 0, foto.Length);
                empresa.emp_foto1 = foto;
            }

            var consulta = "SELECT [emp_nit],[emp_razonSocial] ,[emp_telefono],[emp_email],[emp_paginaWeb],[emp_direccion],[emp_representanteLegar],[emp_telefonoRepresentante],[emp_contrato],[emp_foto1] FROM [seguimiento_empresa].[dbo].[Empresa]";

            var conexion = new Conexion();
            var tabla = conexion.DataAdapter(consulta);
            

            var existe = await BD.seguimiento_Empresa_Entity.Empresa.FirstOrDefaultAsync(p => p.emp_nit == empresa.emp_nit);
            if (existe != null)
            {
                existe.emp_direccion = TxtDireccion.Text.Trim();
                existe.emp_email = txtEmail.Text.Trim();
                existe.emp_paginaWeb = TxtPaginaWeb.Text.Trim();
                existe.emp_razonSocial = TxtRazonSocial.Text.Trim();
                existe.emp_representanteLegar = TxtRepresentante.Text.Trim();
                existe.emp_telefono = TxtTelefono.Text.Trim();
                existe.emp_telefonoRepresentante = TxtTelRepresentante.Text.Trim();
                var res = BD.seguimiento_Empresa_Entity.Entry(existe).State = EntityState.Modified;
                proceso = "actualizado";
            }
            else
            {
                BD.seguimiento_Empresa_Entity.Empresa.Add(empresa);
                proceso = "guardado";
            }
            var respu = await BD.seguimiento_Empresa_Entity.SaveChangesAsync();
            await LoadEmpresa();
            MessageBox.Show($"Los datos de han {proceso}");
            btnAceptar.Enabled = true;
            btnAceptar.UseWaitCursor = false;

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show($"Los datos de han { ex.ToString()}");
            //}

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            BtnContrato.Enabled = false;
            BtnTrabajador.Enabled = false;
            TxtDireccion.Clear();
            txtEmail.Clear();
            TxtNit.Clear();
            TxtPaginaWeb.Clear();
            TxtRazonSocial.Clear();
            TxtRepresentante.Clear();
            TxtTelefono.Clear();
            TxtTelRepresentante.Clear();
            pbxFotografia.Image = null;
            DgvEmpresa.ClearSelection();
            TxtNit.Focus();
        }

        private async void BtnTrabajador_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Seleccione una empresa para continuar");
                return;
            }
            BtnTrabajador.UseWaitCursor = true;
            await Task.Delay(1000);
            formTrabajador formTrabajador = new formTrabajador(TxtNit.Text.Trim());
            formTrabajador.ShowDialog();
            BtnTrabajador.UseWaitCursor = false;

        }

        private async void BtnContrato_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Seleccione una empresa para continuar");
                return;
            }
            BtnContrato.UseWaitCursor = true;
            await Task.Delay(1000);
            formContrato contrato = new formContrato(TxtNit.Text.Trim());
            contrato.ShowDialog();
            BtnContrato.UseWaitCursor = false;

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            ventdialogArchivos.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = ventdialogArchivos.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbxFotografia.Image = Image.FromFile(ventdialogArchivos.FileName);
            }
        }
    }
}
