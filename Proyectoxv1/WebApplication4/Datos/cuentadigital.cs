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
    
    public partial class cuentadigital
    {
        public int id { get; set; }
        public int idacademia { get; set; }
        public int codigo { get; set; }
    
        public virtual academia academia { get; set; }
    }
}