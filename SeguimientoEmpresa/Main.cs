using MaterialSkin.Controls;
using SeguimientoEmpresa.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoEmpresa
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnEmpresas_Click(object sender, EventArgs e)
        {
            formEmpresa form = new formEmpresa();
            form.ShowDialog();
        }

        private async void BtnTrabajador_Click(object sender, EventArgs e)
        {
            BtnTrabajador.UseWaitCursor = true;
            await Task.Delay(1000);
            formTrabajador form = new formTrabajador("");
            form.ShowDialog();
            BtnTrabajador.UseWaitCursor = false;

        }
    }
}
