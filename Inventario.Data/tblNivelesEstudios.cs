//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNivelesEstudios
    {
        public int nivelEstudioID { get; set; }
        public int clienteID { get; set; }
        public string nombreNivel { get; set; }
    
        public virtual tblClientes tblClientes { get; set; }
    }
}
