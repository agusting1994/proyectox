//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class universidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public universidad()
        {
            this.curso = new HashSet<curso>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idciudad { get; set; }
        public string logolink { get; set; }
    
        public virtual ciudad ciudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> curso { get; set; }
    }
}
