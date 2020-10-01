using MaterialSkin.Controls;
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
    public partial class formDetalleAnotaciones : MaterialForm
    {
        string trabajador;
        seguimiento_empresaEntity seguimiento;
        public formDetalleAnotaciones(string trabajador)
        {
            InitializeComponent();
            seguimiento = new seguimiento_empresaEntity();
            this.trabajador = trabajador;
        }

        private async void formDetalleAnotaciones_Load(object sender, EventArgs e)
        {
            var anotaciones = await seguimiento.ContratoDetalle.Where(s => s.detcon_idTrabajador == this.trabajador).ToListAsync();
            if (anotaciones.Count <=0 || anotaciones == null)
            {
                MessageBox.Show("No hay anotaciones");
                this.Dispose();
                return;
            }
            foreach (var item in anotaciones)
            {
                DgvDetalle.Rows.Add(item.detcon_numeroContrato, item.detcon_fecha, item.detcon_descripcion);
            }
        }
    }
}
