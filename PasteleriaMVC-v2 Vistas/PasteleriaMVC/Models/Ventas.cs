//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasteleriaMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            this.DetalleVentas = new HashSet<DetalleVentas>();
        }
    
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int idUsuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVentas> DetalleVentas { get; set; }
    }
}