using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoEmpresa.Reporte
{
   public class DatosReporte
    {
        //public string cont_idEmpresa { get; set; }
        //public string cont_idTrabajador { get; set; }
        public string cont_numero { get; set; }
        public string cont_fecha { get; set; }
        public string cont_descripcion { get; set; }
        public string cont_fechaInicio { get; set; }
        public string cont_fechaFinal { get; set; }
        public string diasRestantes { get; set; }
        //public Nullable<int> cont_idestado { get; set; }
        //public int cont_id { get; set; }
        //public Nullable<int> trab_tipoIdentificacion { get; set; }
        public string trab_identificacion { get; set; }
        public string trab_primerNombre { get; set; }
        public string trab_segundoNombre { get; set; }
        public string trab_primerApellido { get; set; }
        //public string trab_segundoApellido { get; set; }
        //public string trab_nivelEdicativo { get; set; }
        public string trab_direccion { get; set; }
        public string trab_celular { get; set; }
        //public string trab_email { get; set; }
        //public string trab_redSocial { get; set; }
        //public string trab_fechaNacimiento { get; set; }
        //public string trab_profesion { get; set; }
        //public Nullable<int> trab_genero { get; set; }
        //public byte[] trab_foto { get; set; }
        //public string trab_idEmpresa { get; set; }
        public string emp_nit { get; set; }
        public string emp_razonSocial { get; set; }
        public string emp_telefono { get; set; }
        //public string emp_email { get; set; }
        //public string emp_paginaWeb { get; set; }
        public string emp_direccion { get; set; }
        //public string emp_representanteLegar { get; set; }
        //public string emp_telefonoRepresentante { get; set; }
        public string emp_contrato { get; set; }
        //public byte[] emp_foto1 { get; set; }
        //public int est_id { get; set; }
        public string est_descripcion { get; set; }
        //public int tipid_id { get; set; }
        public string tipid_descripcion { get; set; }

    }
}
