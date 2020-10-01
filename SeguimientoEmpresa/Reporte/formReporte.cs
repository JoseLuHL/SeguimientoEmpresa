using SeguimientoEmpresa.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoEmpresa.Reporte
{
    public partial class formReporte : Form
    {
        seguimiento_empresaEntity seguimiento;
        public formReporte()
        {
            InitializeComponent();
            seguimiento = new seguimiento_empresaEntity();
        }

        async Task CargarReporte()
        {
            var contrato = await seguimiento.Contrato.ToListAsync();
            var datosReporte = new ObservableCollection<DatosReporte>();
            foreach (var item in contrato)
            {

                var ven = (DateTime.Now.Date - DateTime.Parse(item.cont_fechaFinal)).Days;
                string vence;
                if (ven < 0)
                {
                    vence = $"{ ven * -1} faltantes";
                }
                else
                {
                    vence = $"{ven} vencidos";
                }

                datosReporte.Add(new DatosReporte
                {
                    cont_fechaFinal = item.cont_fechaFinal,
                    cont_fechaInicio = item.cont_fechaInicio,
                    cont_numero = item.cont_numero,
                    emp_razonSocial = item.Empresa.emp_razonSocial,
                    trab_primerNombre = $"{item.Trabajador.trab_primerNombre} {item.Trabajador.trab_segundoNombre} {item.Trabajador.trab_primerApellido} {item.Trabajador.trab_segundoApellido}",
                    diasRestantes = vence
                });
            }

            var cry = new Reporte();
            this.crystalReportViewer1.ReportSource = cry;
            cry.SetDataSource(datosReporte);
            this.crystalReportViewer1.RefreshReport();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarReporte();
        }
    }
}
