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
    
    public partial class tblPedidosCliente
    {
        public int pedidoID { get; set; }
        public int clienteID { get; set; }
        public int productoID { get; set; }
        public int cantidad { get; set; }
        public string direccionEnvio { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public System.DateTime fechaActualizacion { get; set; }
    
        public virtual tblClientes tblClientes { get; set; }
        public virtual tblProductos tblProductos { get; set; }
    }
}