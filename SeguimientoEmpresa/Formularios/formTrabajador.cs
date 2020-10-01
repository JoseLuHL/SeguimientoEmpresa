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
    public partial class formTrabajador : MaterialForm
    {
        string nit;
        seguimiento_empresaEntity db;
        public formTrabajador(string nit)
        {
            InitializeComponent();
            this.nit = nit;
            db = new seguimiento_empresaEntity();
        }

        async Task LoadTrabajador(string empresa)
        {
            DgTrabajador.Rows.Clear();
            //var trabajadores = db.
            var trabajador = await db.Trabajador.Where(p => p.trab_idEmpresa == empresa || p.Contrato.Any(s => s.cont_idEmpresa == empresa)).ToListAsync();
            if (trabajador == null)
            {
                return;
            }

            foreach (var item in trabajador)
            {
                DgTrabajador.Rows.Add(item.trab_identificacion,
                    $"{item.trab_primerNombre} " +
                    $"{item.trab_segundoNombre} " +
                    $"{item.trab_primerApellido} " +
                    $"{item.trab_segundoApellido}",
                     item.trab_celular);
            }
        }

        private async void formTrabajador_Load(object sender, EventArgs e)
        {
            await LoadTrabajador(this.nit);
            var genero = await db.Genero.ToListAsync();
            CboGenero.DataSource = genero;
            CboGenero.ValueMember = "gen_id";
            CboGenero.DisplayMember = "gen_descripcion";

            var tipoIden = await db.TipoIdentificacion.ToListAsync();
            CboTipoIde.DataSource = tipoIden;
            CboTipoIde.ValueMember = "tipid_id";
            CboTipoIde.DisplayMember = "tipid_descripcion";


            DgTrabajador.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16, GraphicsUnit.World);
            foreach (DataGridViewColumn c in DgTrabajador.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Century Gothic", 15, GraphicsUnit.World);
            }
            DgTrabajador.EnableHeadersVisualStyles = false;
            DgTrabajador.ClearSelection();
        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
        }

        private async void DgTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idTrabajador = DgTrabajador.Rows[e.RowIndex].Cells["DgTrabajadorColIdentificacion"].Value.ToString();
                var existe = await db
                    .Trabajador.FirstOrDefaultAsync(p => p.trab_identificacion == idTrabajador);
                if (existe == null)
                {
                    MessageBox.Show("Sin resultados");
                    return;
                }
                TxtTelefono.Text = existe.trab_celular;
                TxtDireccion.Text = existe.trab_direccion;
                TxtEmail.Text = existe.trab_email;
                cmbFechaNac.Text = existe.trab_fechaNacimiento;
                CboGenero.SelectedValue = existe.trab_genero;
                TxtIdentificacion.Text = existe.trab_identificacion;
                TxtNivelEducativo.Text = existe.trab_nivelEdicativo;
                TxtPrimerApellido.Text = existe.trab_primerApellido;
                TxtPirmerNombre.Text = existe.trab_primerNombre;
                TxtProfesion.Text = existe.trab_profesion;
                TxtRedSocial.Text = existe.trab_redSocial;
                TxtSegundoApellido.Text = existe.trab_segundoApellido;
                TxtSegundoNombre.Text = existe.trab_segundoNombre;
                CboTipoIde.SelectedValue = existe.trab_tipoIdentificacion;
                this.nit = existe.trab_idEmpresa;
                pbxFotografia.Image = null;
                if (existe.trab_foto != null)
                {
                    MemoryStream ms = new MemoryStream(existe.trab_foto);
                    pbxFotografia.Image = Image.FromStream(ms);
                }
            }
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

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string operacion;
            try
            {
                if (string.IsNullOrEmpty(TxtIdentificacion.Text))
                {
                    MessageBox.Show("Ingrse una identificación");
                    btnAceptar.UseWaitCursor = false;
                    return;
                }

                if (string.IsNullOrEmpty(TxtPirmerNombre.Text))
                {
                    MessageBox.Show("Ingrse el primer nombre");
                    btnAceptar.UseWaitCursor = false;
                    return;
                }

                if (string.IsNullOrEmpty(TxtPrimerApellido.Text))
                {
                    MessageBox.Show("Ingrse el primer apellido");
                    btnAceptar.UseWaitCursor = false;

                    return;
                }
                btnAceptar.UseWaitCursor = true;
                await Task.Delay(1000);
                var trabajador = new Trabajador();
                trabajador.trab_celular = TxtTelefono.Text.Trim();
                trabajador.trab_direccion = TxtDireccion.Text.Trim();
                trabajador.trab_email = TxtEmail.Text.Trim();
                trabajador.trab_fechaNacimiento = cmbFechaNac.Text;
                trabajador.trab_genero = int.Parse(CboGenero.SelectedValue.ToString());
                trabajador.trab_identificacion = TxtIdentificacion.Text.Trim();
                trabajador.trab_nivelEdicativo = TxtNivelEducativo.Text.Trim();
                trabajador.trab_primerApellido = TxtPrimerApellido.Text.Trim();
                trabajador.trab_primerNombre = TxtPirmerNombre.Text.Trim();
                trabajador.trab_profesion = TxtProfesion.Text.Trim();
                trabajador.trab_redSocial = TxtRedSocial.Text.Trim();
                trabajador.trab_segundoApellido = TxtSegundoApellido.Text.Trim();
                trabajador.trab_segundoNombre = TxtSegundoNombre.Text.Trim();
                trabajador.trab_tipoIdentificacion = int.Parse(CboTipoIde.SelectedValue.ToString());
                trabajador.trab_idEmpresa = this.nit;

                byte[] foto = null;
                if (pbxFotografia.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbxFotografia.Image.Save(ms, ImageFormat.Jpeg);
                    foto = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(foto, 0, foto.Length);
                    trabajador.trab_foto = foto;
                }


                var existe = await db.Trabajador.FirstOrDefaultAsync(p => p.trab_identificacion == trabajador.trab_identificacion);

                if (existe != null)
                {
                    existe.trab_foto = foto;
                    existe.trab_celular = TxtTelefono.Text.Trim();
                    existe.trab_direccion = TxtDireccion.Text.Trim();
                    existe.trab_email = TxtEmail.Text.Trim();
                    existe.trab_fechaNacimiento = cmbFechaNac.Text;
                    existe.trab_genero = int.Parse(CboGenero.SelectedValue.ToString());
                    existe.trab_identificacion = TxtIdentificacion.Text.Trim();
                    existe.trab_nivelEdicativo = TxtNivelEducativo.Text.Trim();
                    existe.trab_primerApellido = TxtPrimerApellido.Text.Trim();
                    existe.trab_primerNombre = TxtPirmerNombre.Text.Trim();
                    existe.trab_profesion = TxtProfesion.Text.Trim();
                    existe.trab_redSocial = TxtRedSocial.Text.Trim();
                    existe.trab_segundoApellido = TxtSegundoApellido.Text.Trim();
                    existe.trab_segundoNombre = TxtSegundoNombre.Text.Trim();
                    existe.trab_tipoIdentificacion = int.Parse(CboTipoIde.SelectedValue.ToString());
                    existe.trab_idEmpresa = this.nit;
                    var res = db.Entry(existe).State = EntityState.Modified;
                    operacion = "actualizado";
                }
                else
                {
                    db.Trabajador.Add(trabajador);
                    operacion = "guardado";
                }
                await db.SaveChangesAsync();

                await LoadTrabajador(this.nit);
                MessageBox.Show($"Datos {operacion} correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnAceptar.UseWaitCursor = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnotaciones_Click(object sender, EventArgs e)
        {
            new formDetalleAnotaciones(TxtIdentificacion.Text.Trim()).ShowDialog();
        }
    }
}
