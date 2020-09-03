using SeguimientoEmpresa.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoEmpresa.Formularios
{
    public partial class formTrabajador : Form
    {
        string nit;
        public formTrabajador(string nit)
        {
            InitializeComponent();
            this.nit = nit;
        }

        async Task LoadTrabajador(string empresa)
        {
            DgTrabajador.Rows.Clear();
            var trabajador = await BD.seguimiento_Empresa_Entity.Trabajador.Where(p => p.trab_idEmpresa == empresa).ToListAsync();
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
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            string operacion;
            try
            {
                var trabajador = new Trabajador();
                trabajador.trab_celular = TxtTelefono.Text.Trim();
                trabajador.trab_direccion = TxtDireccion.Text.Trim();
                trabajador.trab_email = TxtEmail.Text.Trim();
                trabajador.trab_fechaNacimiento = cmbFechaNac.Text;
                trabajador.trab_genero = TxtGenero.Text.Trim();
                trabajador.trab_identificacion = TxtIdentificacion.Text.Trim();
                trabajador.trab_nivelEdicativo = TxtNivelEducativo.Text.Trim();
                trabajador.trab_primerApellido = TxtPrimerApellido.Text.Trim();
                trabajador.trab_primerNombre = TxtPirmerNombre.Text.Trim();
                trabajador.trab_profesion = TxtProfesion.Text.Trim();
                trabajador.trab_redSocial = TxtRedSocial.Text.Trim();
                trabajador.trab_segundoApellido = TxtSegundoApellido.Text.Trim();
                trabajador.trab_segundoNombre = TxtSegundoNombre.Text.Trim();
                trabajador.trab_tipoIdentificacion = TxtTipoIdentificacion.Text.Trim();
                trabajador.trab_idEmpresa = this.nit;

                var existe = await BD.seguimiento_Empresa_Entity.Trabajador.FirstOrDefaultAsync(p => p.trab_identificacion == trabajador.trab_identificacion);

                if (existe != null)
                {

                    existe.trab_celular = TxtTelefono.Text.Trim();
                    existe.trab_direccion = TxtDireccion.Text.Trim();
                    existe.trab_email = TxtEmail.Text.Trim();
                    existe.trab_fechaNacimiento = cmbFechaNac.Text;
                    existe.trab_genero = TxtGenero.Text.Trim();
                    existe.trab_identificacion = TxtIdentificacion.Text.Trim();
                    existe.trab_nivelEdicativo = TxtNivelEducativo.Text.Trim();
                    existe.trab_primerApellido = TxtPrimerApellido.Text.Trim();
                    existe.trab_primerNombre = TxtPirmerNombre.Text.Trim();
                    existe.trab_profesion = TxtProfesion.Text.Trim();
                    existe.trab_redSocial = TxtRedSocial.Text.Trim();
                    existe.trab_segundoApellido = TxtSegundoApellido.Text.Trim();
                    existe.trab_segundoNombre = TxtSegundoNombre.Text.Trim();
                    existe.trab_tipoIdentificacion = TxtTipoIdentificacion.Text.Trim();
                    existe.trab_idEmpresa = this.nit;
                    var res = BD.seguimiento_Empresa_Entity.Entry(existe).State = EntityState.Modified;
                    operacion = "actualizado";
                }
                else
                {
                    BD.seguimiento_Empresa_Entity.Trabajador.Add(trabajador);
                    operacion = "guardado";
                }
                await BD.seguimiento_Empresa_Entity.SaveChangesAsync();

                await LoadTrabajador(this.nit);
                MessageBox.Show($"Datos {operacion} correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void DgTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idTrabajador = DgTrabajador.Rows[e.RowIndex].Cells["DgTrabajadorColIdentificacion"].Value.ToString();
                var existe = await BD.seguimiento_Empresa_Entity
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
                TxtGenero.Text = existe.trab_genero;
                TxtIdentificacion.Text = existe.trab_identificacion;
                TxtNivelEducativo.Text = existe.trab_nivelEdicativo;
                TxtPrimerApellido.Text = existe.trab_primerApellido;
                TxtPirmerNombre.Text = existe.trab_primerNombre;
                TxtProfesion.Text = existe.trab_profesion;
                TxtRedSocial.Text = existe.trab_redSocial;
                TxtSegundoApellido.Text = existe.trab_segundoApellido;
                TxtSegundoNombre.Text = existe.trab_segundoNombre;
                TxtTipoIdentificacion.Text = existe.trab_tipoIdentificacion;
                this.nit = existe.trab_idEmpresa;

            }
        }
    }
}
