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
    
    public partial class materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public materia()
        {
            this.profesor_materia = new HashSet<profesor_materia>();
            this.video = new HashSet<video>();
        }
    
        public int idmateria { get; set; }
        public int idcurso { get; set; }
        public string nombre { get; set; }
        public string abreviatura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<profesor_materia> profesor_materia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<video> video { get; set; }
        public virtual curso curso { get; set; }
    }
}