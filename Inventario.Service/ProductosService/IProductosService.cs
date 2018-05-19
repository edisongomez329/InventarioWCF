using System.Collections.Generic;
using System.ServiceModel;
using Inventario.Data;
using Inventario.Models;

namespace Inventario.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name 
    //"IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductosService
    {
        [OperationContract]
        bool CrearProducto(ProductosModel producto);

        [OperationContract]
        ProductosModel ConsultarProductoPorId(int id);

        [OperationContract]
        IEnumerable<ProductosModel> ConsultarProductosPorNombre(string nombre);
    }
}
