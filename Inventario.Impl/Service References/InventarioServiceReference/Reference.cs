﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.Impl.InventarioServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InventarioServiceReference.IProductosService")]
    public interface IProductosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductosService/CrearProducto", ReplyAction="http://tempuri.org/IProductosService/CrearProductoResponse")]
        bool CrearProducto(Inventario.Models.ProductosModel producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductosService/CrearProducto", ReplyAction="http://tempuri.org/IProductosService/CrearProductoResponse")]
        System.Threading.Tasks.Task<bool> CrearProductoAsync(Inventario.Models.ProductosModel producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductosService/ConsultarProductoPorId", ReplyAction="http://tempuri.org/IProductosService/ConsultarProductoPorIdResponse")]
        Inventario.Models.ProductosModel ConsultarProductoPorId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductosService/ConsultarProductoPorId", ReplyAction="http://tempuri.org/IProductosService/ConsultarProductoPorIdResponse")]
        System.Threading.Tasks.Task<Inventario.Models.ProductosModel> ConsultarProductoPorIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductosService/ConsultarProductosPorNombre", ReplyAction="http://tempuri.org/IProductosService/ConsultarProductosPorNombreResponse")]
        Inventario.Models.ProductosModel[] ConsultarProductosPorNombre(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductosService/ConsultarProductosPorNombre", ReplyAction="http://tempuri.org/IProductosService/ConsultarProductosPorNombreResponse")]
        System.Threading.Tasks.Task<Inventario.Models.ProductosModel[]> ConsultarProductosPorNombreAsync(string nombre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductosServiceChannel : Inventario.Impl.InventarioServiceReference.IProductosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductosServiceClient : System.ServiceModel.ClientBase<Inventario.Impl.InventarioServiceReference.IProductosService>, Inventario.Impl.InventarioServiceReference.IProductosService {
        
        public ProductosServiceClient() {
        }
        
        public ProductosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CrearProducto(Inventario.Models.ProductosModel producto) {
            return base.Channel.CrearProducto(producto);
        }
        
        public System.Threading.Tasks.Task<bool> CrearProductoAsync(Inventario.Models.ProductosModel producto) {
            return base.Channel.CrearProductoAsync(producto);
        }
        
        public Inventario.Models.ProductosModel ConsultarProductoPorId(int id) {
            return base.Channel.ConsultarProductoPorId(id);
        }
        
        public System.Threading.Tasks.Task<Inventario.Models.ProductosModel> ConsultarProductoPorIdAsync(int id) {
            return base.Channel.ConsultarProductoPorIdAsync(id);
        }
        
        public Inventario.Models.ProductosModel[] ConsultarProductosPorNombre(string nombre) {
            return base.Channel.ConsultarProductosPorNombre(nombre);
        }
        
        public System.Threading.Tasks.Task<Inventario.Models.ProductosModel[]> ConsultarProductosPorNombreAsync(string nombre) {
            return base.Channel.ConsultarProductosPorNombreAsync(nombre);
        }
    }
}
