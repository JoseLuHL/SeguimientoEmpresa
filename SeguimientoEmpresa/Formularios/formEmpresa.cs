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
    public partial class formEmpresa : Form
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
            await LoadEmpresa();
        }

        async Task DatosEmpresa(string nit)
        {
            var empresa = await BD.seguimiento_Empresa_Entity.Empresa.FirstOrDefaultAsync(s => s.emp_nit == nit);
            if (empresa == null)
            {
                MessageBox.Show("Sin resultados");
                return;
            }

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
            var empresa = new Empresa();

            #region VALIDACIONES
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Ingrese un nit", "Nit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                MessageBox.Show("Ingrese una razon social", "Razon social", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtRepresentante.Text))
            {
                MessageBox.Show("Ingrese una representante lega", "Representante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Ingrese un email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
            {
                MessageBox.Show("Ingrese una dirección", "Direccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            //try
            //{

            if (MessageBox.Show("¿Esta seguro de continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

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

            MemoryStream ms = new MemoryStream();
            pbxFotografia.Image.Save(ms, ImageFormat.Jpeg);
            byte[] foto = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(foto, 0, foto.Length);
            empresa.emp_foto1 = foto;

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

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show($"Los datos de han { ex.ToString()}");
            //}

        }

        private void gpbxDatosGenerales_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargarF_Click(object sender, EventArgs e)
        {
            ventdialogArchivos.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = ventdialogArchivos.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbxFotografia.Image = Image.FromFile(ventdialogArchivos.FileName);
            }
        }

        private void BtnTrabajadores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Seleccione una empresa para continuar");
                return;
            }

            formTrabajador formTrabajador = new formTrabajador(TxtNit.Text.Trim());
            formTrabajador.ShowDialog();
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
            formContrato contrato = new formContrato("");
            contrato.ShowDialog();
        }
    }
}
