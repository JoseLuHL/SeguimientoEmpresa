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
    public partial class formContrato : Form
    {
        string empresa;
        public formContrato(string idEmpresa)
        {
            InitializeComponent();
            this.empresa = idEmpresa;
        }

        async Task LoadContratos(string empresa)
        {
            DgvEmpresa.Rows.Clear();
            var contratos = await BD.seguimiento_Empresa_Entity.Contrato.Where(s => s.cont_idEmpresa == empresa).ToListAsync();
            if (contratos.Count <= 0)
                return;

            foreach (var item in contratos)
            {
                DgvEmpresa.Rows.Add(item.cont_numero,
                    $"{item.Trabajador.trab_primerNombre} " +
                    $"{item.Trabajador.trab_segundoNombre} " +
                    $"{item.Trabajador.trab_primerApellido} " +
                    $"{item.Trabajador.trab_segundoApellido}",
                    item.cont_fechaInicio, item.cont_fechaFinal, item.cont_estado);
            }
        }
        private async void formContrato_Load(object sender, EventArgs e)
        {
            await LoadContratos(this.empresa);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            var contrato = new Contrato();
            contrato.cont_fecha = DateTime.Now.Date.ToShortDateString();
            contrato.cont_fechaInicio = TxtFechaInicio.Text.Trim();
            contrato.cont_fechaFinal = TxtFechaFinal.Text.Trim();
            contrato.cont_estado = TxtEstado.Text.Trim();
            contrato.cont_idEmpresa = empresa;
            contrato.cont_idTrabajador = TxtIdentificacion.Text.Trim();

            BD.seguimiento_Empresa_Entity.Contrato.Add(contrato);
            await BD.seguimiento_Empresa_Entity.SaveChangesAsync();

            //var existe = await BD.seguimiento_Empresa_Entity
            //if (true)
            //{

            //}



        }
    }
}
