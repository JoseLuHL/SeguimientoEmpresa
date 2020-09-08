//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeguimientoEmpresa.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trabajador()
        {
            this.Beneficiario = new HashSet<Beneficiario>();
            this.Contrato = new HashSet<Contrato>();
        }
    
        public Nullable<int> trab_tipoIdentificacion { get; set; }
        public string trab_identificacion { get; set; }
        public string trab_primerNombre { get; set; }
        public string trab_segundoNombre { get; set; }
        public string trab_primerApellido { get; set; }
        public string trab_segundoApellido { get; set; }
        public string trab_nivelEdicativo { get; set; }
        public string trab_direccion { get; set; }
        public string trab_celular { get; set; }
        public string trab_email { get; set; }
        public string trab_redSocial { get; set; }
        public string trab_fechaNacimiento { get; set; }
        public string trab_profesion { get; set; }
        public Nullable<int> trab_genero { get; set; }
        public byte[] trab_foto { get; set; }
        public string trab_idEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beneficiario> Beneficiario { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}
