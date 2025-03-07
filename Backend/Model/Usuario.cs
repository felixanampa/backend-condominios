//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Departamento = new HashSet<Departamento>();
            this.Departamento1 = new HashSet<Departamento>();
            this.Recibo = new HashSet<Recibo>();
            this.Recibo1 = new HashSet<Recibo>();
            this.Reserva = new HashSet<Reserva>();
        }
    
        public int idusuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public int Idrol { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public Nullable<int> usuariocreacion { get; set; }
        public Nullable<System.DateTime> fechacreacion { get; set; }
        public Nullable<int> usuariomodificacion { get; set; }
        public Nullable<System.DateTime> fechamodificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Departamento> Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Departamento> Departamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
