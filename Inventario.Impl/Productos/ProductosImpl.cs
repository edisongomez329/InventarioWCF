using System;
using System.Collections.Generic;
using Inventario.Models;
using Inventario.Impl.CommandPattern.Interface;
using Inventario.Impl.CommandPattern.Commands;

namespace Inventario.Impl.Productos
{
    public class ProductosImpl : IProductosImpl
    {
        InventarioServiceReference.IProductosService _service;
        ICommand<IEnumerable<ProductosModel>> _consultarProductosCommand;
        public ProductosImpl()
        {
            _service = new InventarioServiceReference.ProductosServiceClient();
            _consultarProductosCommand = new ConsultarProductosCommand();
        }

        public IEnumerable<ProductosModel> ConsultarProductosPorNombreCommand(string nombre)
        {
            try
            {
                Parametros parametros = new Parametros() { valor = nombre };
                
                var rta = _consultarProductosCommand.Execute(parametros);
                return rta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public bool CrearProducto(ProductosModel producto)
        {
            try
            {
                return _service.CrearProducto(producto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ProductosModel ConsultarProductoPorId(int id)
        {
            try
            {
                return _service.ConsultarProductoPorId(id);
            }
            catch (ApplicationException ae)
            {                
                throw new ApplicationException(ae.Message);
            }
        }

        public IEnumerable<ProductosModel> ConsultarProductosPorNombre(string nombre)
        {
            try
            {
                return _service.ConsultarProductosPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
