using System.Collections.Generic;
using Inventario.Models;

namespace Inventario.Impl.Productos
{
    public interface IProductosImpl
    {
        bool CrearProducto(ProductosModel producto);

        ProductosModel ConsultarProductoPorId(int id);

        IEnumerable<ProductosModel> ConsultarProductosPorNombre(string nombre);

        IEnumerable<ProductosModel> ConsultarProductosPorNombreCommand(string nombre);
    }
}
