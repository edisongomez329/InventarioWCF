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
    
    public partial class tblConceptoIngresosEgresos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblConceptoIngresosEgresos()
        {
            this.tblIngresosEgresos = new HashSet<tblIngresosEgresos>();
        }
    
        public int conceptoID { get; set; }
        public int tipoRegistroID { get; set; }
        public string descTipoConcepto { get; set; }
    
        public virtual tblTiposRegistro tblTiposRegistro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIngresosEgresos> tblIngresosEgresos { get; set; }
    }
}
