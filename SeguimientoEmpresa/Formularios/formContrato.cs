using MaterialSkin.Controls;
using SeguimientoEmpresa.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoEmpresa.Formularios
{
    public partial class formContrato : MaterialForm
    {
        string empresa;
        seguimiento_empresaEntity db;
        public formContrato(string idEmpresa)
        {
            InitializeComponent();
            this.empresa = idEmpresa;
            db = new seguimiento_empresaEntity();
        }

        async Task LoadContratos(string empresa, string idTrabajador)
        {
            DgvEmpresa.Rows.Clear();
            var contratos = await db.Contrato.Where(s => s.cont_idEmpresa == empresa).ToListAsync();
            if (!string.IsNullOrEmpty(idTrabajador))
            {
                contratos = await db.Contrato.Where(s => s.cont_idEmpresa == empresa && s.cont_idTrabajador == idTrabajador).ToListAsync();
            }

            else
            if (contratos.Count <= 0)
                return;
            contratos = new List<Contrato>(contratos.OrderBy(s => s.cont_idestado));

            foreach (var item in contratos)
            {
                DgvEmpresa.Rows.Add(item.cont_id, item.cont_numero,
                    $"{item.Trabajador.trab_primerNombre} " +
                    $"{item.Trabajador.trab_segundoNombre} " +
                    $"{item.Trabajador.trab_primerApellido} " +
                    $"{item.Trabajador.trab_segundoApellido}",
                    item.Trabajador.trab_identificacion,
                    item.cont_fechaInicio,
                    item.cont_fechaFinal,
                    item.EstadoContrato.est_descripcion);
            }
            //foreach (var item in contratos)
            //{

            //}

        }
        private async void formContrato_Load(object sender, EventArgs e)
        {
            btnAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;

            await LoadContratos(this.empresa, "");
            var estado = await db.EstadoContrato.ToListAsync();
            CboEstado.DataSource = estado;
            CboEstado.DisplayMember = "est_descripcion";
            CboEstado.ValueMember = "est_id";

            DgvDetalleColMotivo.DataSource = await db.Motivo.ToListAsync();
            DgvDetalleColMotivo.DisplayMember = "mot_descipcion";
            DgvDetalleColMotivo.ValueMember = "mot_id";


            DgvEmpresa.ClearSelection();
            DgvDetalle.ClearSelection();
        }

        async Task BuscarTrabajadorAsync()
        {
            var trabajador = await db.Trabajador
                    .FirstOrDefaultAsync(p => p.trab_identificacion == TxtIdentificacion.Text.Trim());
            if (trabajador == null)
            {
                MessageBox.Show("No se ha encontrado el trabajador");
                return;
            }
            TxtTrabajador.Text = $"{trabajador.trab_primerNombre} " +
                $"{trabajador.trab_segundoApellido} " +
                $"{trabajador.trab_primerApellido} " +
                $"{trabajador.trab_segundoApellido}";
        }
        private async void TxtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await BuscarTrabajadorAsync();
            }
        }

        bool grid = false;
        private async void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (grid == false)
            {
                DgvEmpresa.Rows.Clear();
                TxtDescripcion.Clear();
                TxtTrabajador.Clear();
                TxtNumeroContrato.Clear();
                DgvDetalle.Rows.Clear();
                btnAceptar.Enabled = true;
                CboEstado.SelectedValue = 1;
                await ExisteContratoAsync();
                DgvEmpresa.ClearSelection();

                if (TxtIdentificacion.Text.Trim().Length == 10)
                {
                    await BuscarTrabajadorAsync();
                }
            }
            grid = false;
        }

        private async void BtnNuevo_Click(object sender, EventArgs e)
        {
            var existe = await db.Contrato.FirstOrDefaultAsync(p => p.cont_idTrabajador == TxtIdentificacion.Text && p.cont_idestado != 3);
            if (existe != null)
            {

            }
        }

        private async void DgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    grid = true;
                    var empresa = this.empresa;
                    var trabajador = DgvEmpresa.Rows[e.RowIndex].Cells["DgvColIdentificacion"].Value.ToString();
                    var Numero = DgvEmpresa.Rows[e.RowIndex].Cells["DgvColNumero"].Value.ToString();
                    var Id = int.Parse(DgvEmpresa.Rows[e.RowIndex].Cells["DgvColId"].Value.ToString());

                    var contrato = await db.Contrato
                       .FirstOrDefaultAsync(p => p.cont_id == Id);

                    DtFechaInicio.Text = contrato.cont_fechaInicio;
                    DtFechaFinal.Text = contrato.cont_fechaFinal;
                    CboEstado.SelectedValue = contrato.EstadoContrato.est_id;
                    TxtDescripcion.Text = contrato.cont_descripcion;
                    TxtNumeroContrato.Text = contrato.cont_numero;
                    TxtIdentificacion.Text = contrato.cont_idTrabajador;
                    TxtTrabajador.Text = $"{contrato.Trabajador.trab_primerNombre} " +
                        $"{contrato.Trabajador.trab_segundoApellido} " +
                        $"{contrato.Trabajador.trab_primerApellido} " +
                        $"{contrato.Trabajador.trab_segundoApellido}";

                    CboEstado.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnAceptar.Text = "Aceptar";
                    if (contrato.EstadoContrato.est_descripcion == "Activo")
                    {
                        btnAceptar.Text = "Actualizar";
                        btnAceptar.Enabled = true;
                        CboEstado.Enabled = true;
                    }

                    DgvDetalle.Rows.Clear();
                    var x = 0;
                    foreach (var item in contrato.ContratoDetalle)
                    {
                        DgvDetalle.Rows.Add(item.detcon_descripcion,
                            item.Motivo.mot_id,
                            item.detcon_resultado);
                        //DgvDetalle.Rows[x].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var contrato = new Contrato();

                if (DtFechaInicio.Value >= DtFechaFinal.Value)
                {
                    MessageBox.Show("Fechas no validas");
                    return;
                }

                if (string.IsNullOrEmpty(TxtTrabajador.Text))
                {
                    MessageBox.Show("Ingrese un trabajador");
                    return;
                }
                if (string.IsNullOrEmpty(TxtNumeroContrato.Text))
                {
                    MessageBox.Show("Ingrese un numero de contrato");
                    return;
                }

                contrato.cont_fecha = DateTime.Now.Date.ToShortDateString();
                contrato.cont_fechaInicio = DtFechaInicio.Text.Trim();
                contrato.cont_fechaFinal = DtFechaFinal.Text.Trim();
                contrato.cont_idestado = int.Parse(CboEstado.SelectedValue.ToString());
                contrato.cont_idEmpresa = empresa;
                contrato.cont_descripcion = TxtDescripcion.Text.Trim();
                contrato.cont_numero = TxtNumeroContrato.Text.Trim();
                contrato.cont_idTrabajador = TxtIdentificacion.Text.Trim();

                var contratoDetalle = new List<ContratoDetalle>();

                #region Detalle
                if (DgvDetalle.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in DgvDetalle.Rows)
                    {
                        if (item.Cells["DgvDetalleColDescripcion"].Value != null && item.Cells["DgvDetalleColResultado"].Value != null)
                        {
                            var descripcion = item.Cells["DgvDetalleColDescripcion"].Value.ToString();
                            var motivo = item.Cells["DgvDetalleColMotivo"].Value.ToString();
                            var resultado = item.Cells["DgvDetalleColResultado"].Value.ToString();
                            contratoDetalle.Add(new ContratoDetalle
                            {
                                detcon_descripcion = descripcion,
                                detcon_resultado = resultado,
                                detcon_idMotivo = int.Parse(motivo),
                                detcon_hora = DateTime.Now.Date.ToShortTimeString(),
                                detcon_fecha = DateTime.Now.Date.ToShortDateString(),
                                detcon_idTrabajador = TxtIdentificacion.Text.Trim(),
                                detcon_idEmpresa = this.empresa,
                                detcon_numeroContrato = TxtNumeroContrato.Text.Trim(),
                            });
                        }
                    }
                }
                #endregion
                contrato.ContratoDetalle = contratoDetalle;
                var existe = await db.Contrato.FirstOrDefaultAsync(p => p.cont_idTrabajador == contrato.cont_idTrabajador && p.cont_idEmpresa == this.empresa && p.cont_idestado == 1);
                if (existe == null)
                {
                    //VERIFICAR EL NUMERO DE CONTRATO
                    var NumeroC = await NumeroContratoAsync(TxtNumeroContrato.Text.Trim());
                    if (NumeroC)
                    {
                        MessageBox.Show("El numero de contrato ya existe");
                        return;
                    }
                    if (MessageBox.Show("¿Desea agregar el contrato?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        contrato.cont_idestado = 1;
                        db.Contrato.Add(contrato);
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea actualizar el contrato?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        existe.cont_fecha = DateTime.Now.Date.ToShortDateString();
                        existe.cont_fechaInicio = DtFechaInicio.Text.Trim();
                        existe.cont_fechaFinal = DtFechaFinal.Text.Trim();
                        existe.cont_idestado = int.Parse(CboEstado.SelectedValue.ToString());
                        existe.cont_descripcion = TxtDescripcion.Text.Trim();
                        existe.cont_numero = TxtNumeroContrato.Text.Trim();

                        existe.ContratoDetalle = contratoDetalle;
                        foreach (var item in contratoDetalle)
                        {
                            var elimina = await db.ContratoDetalle.FirstOrDefaultAsync(p => p.detcon_idTrabajador == item.detcon_idTrabajador
                            && p.detcon_idEmpresa == item.detcon_idEmpresa);
                            if (elimina != null)
                            {
                                db.ContratoDetalle.Remove(elimina);
                            }
                        }
                        db.Entry(existe).State = EntityState.Modified;
                    }
                }
                await db.SaveChangesAsync();
                await LoadContratos(this.empresa, TxtIdentificacion.Text.Trim());
                MessageBox.Show("Operación completada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        async Task<bool> NumeroContratoAsync(string numero)
        {
            bool respuesta = false;
            var contrato = await db.Contrato.FirstOrDefaultAsync(s => s.cont_numero == numero);
            if (contrato != null)
                respuesta = true;
            return respuesta;
        }
        private async void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(TxtIdentificacion.Text))
            //{
            //    MessageBox.Show("Ingrese un numero de identificación para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //var existe = await db.Contrato.FirstOrDefaultAsync(p => p.cont_idTrabajador == TxtIdentificacion.Text.Trim() && p.cont_idEmpresa == this.empresa && p.cont_idestado == 1);
            //if (existe != null)
            //{
            //    if (MessageBox.Show("Entre grabajador tiene un contrato abierto \n ¿Desea serrarlo para continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //        return;

            //}

            //if (MessageBox.Show("¿Esta seguro de crear el contrato", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    return;


        }
        private async void BtnCancelar_Click(object sender, EventArgs e)
        {
            grid = true;
            TxtDescripcion.Clear();
            TxtIdentificacion.Clear();
            TxtTrabajador.Clear();
            TxtNumeroContrato.Clear();
            DgvDetalle.ClearSelection();
            DgvDetalle.Rows.Clear();
            btnAceptar.Enabled = true;
            CboEstado.SelectedValue = 1;
            CboEstado.Enabled = true;
            btnAceptar.Text = "Aceptar";
            await LoadContratos(this.empresa, "");
            DgvEmpresa.ClearSelection();
        }

        async Task ExisteContratoAsync()
        {
            //bool respuesta = false;
            if (!string.IsNullOrEmpty(TxtIdentificacion.Text))
            {
                var existente = await db.Contrato.Where(s => s.cont_idEmpresa == this.empresa && s.cont_idTrabajador == TxtIdentificacion.Text.Trim()).ToListAsync();
                if (existente.Count > 0)
                {
                    await LoadContratos(this.empresa, TxtIdentificacion.Text.Trim());

                    TxtTrabajador.Text = $"{existente[0].Trabajador.trab_primerNombre} " +
                       $"{existente[0].Trabajador.trab_segundoApellido} " +
                       $"{existente[0].Trabajador.trab_primerApellido} " +
                       $"{existente[0].Trabajador.trab_segundoApellido}";
                    //respuesta = true;
                }
                else
                    DgvEmpresa.Rows.Clear();
            }
            else
                await LoadContratos(this.empresa, "");
        }
    }
}
