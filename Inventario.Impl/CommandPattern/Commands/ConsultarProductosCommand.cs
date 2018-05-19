using Inventario.Models;
using Inventario.Impl.CommandPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventario.Impl.InventarioServiceReference;

namespace Inventario.Impl.CommandPattern.Commands
{
    public class ConsultarProductosCommand : ICommand<IEnumerable<ProductosModel>>
    {
        IProductosService _service;

        public ConsultarProductosCommand()
        {
            _service = new ProductosServiceClient();
        }

        public IEnumerable<ProductosModel> Execute(IParams param)
        {
            try
            {
                Parametros _parametros = (Parametros)param;
                return _service.ConsultarProductosPorNombre(_parametros.valor);
            }
            catch (Exception ex)
            {                
                throw;
            }
        }
    }
}