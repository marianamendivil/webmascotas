//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upb.tabd.broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mascota()
        {
            this.ControlPesoes = new HashSet<ControlPeso>();
            this.Vacunacions = new HashSet<Vacunacion>();
        }
    
        public long Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<double> IdentCliente { get; set; }
        public Nullable<long> IdRaza { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlPeso> ControlPesoes { get; set; }
        public virtual Raza Raza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacunacion> Vacunacions { get; set; }
    }
}
