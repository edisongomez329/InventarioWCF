using Inventario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Inventario.Models;

namespace Inventario.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ProductosService : IProductosService
    {
        InventarioEntities _context;
        public ProductosService()
        {
            _context = new InventarioEntities();
        }

        public bool CrearProducto(ProductosModel producto)
        {
            try
            {
                if (producto == null) throw new ArgumentNullException("Debe agregar un producto.");
                tblProductos tProducto = new tblProductos()
                {
                    stockProducto = producto.Stock,
                    nomProducto = producto.Nombre,
                    costoProducto = producto.Costo,                    
                    categoriaID = 1,
                };
                _context.tblProductos.Add(tProducto);
                _context.Entry(tProducto).State = EntityState.Added;
                return _context.SaveChanges() > 0;
            }
            catch (ArgumentNullException ne)
            {
                throw new ArgumentNullException(ne.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrio un error al crear el producto.");
            }
        }

        public ProductosModel ConsultarProductoPorId(int id)
        {
            try
            {
                var result = _context.tblProductos.Find(id);
                if (result == null) throw new ApplicationException("No se encontro el producto especificado.");
                return new ProductosModel
                {
                    Nombre = result.nomProducto,
                    Stock = result.stockProducto,
                    IdCategoria = result.categoriaID,
                    Costo = result.costoProducto,
                    Id = result.productoID
                };
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al consultar el producto.");
            }
        }

        public IEnumerable<ProductosModel> ConsultarProductosPorNombre(string nombre)
        {
            try
            {
                var result = _context.tblProductos.Where(p => string.IsNullOrEmpty(nombre) ? true : nombre.Contains(p.nomProducto))
                                            .ToList();
                return result.Select(p => new ProductosModel
                    {
                        Nombre = p.nomProducto,
                        Stock = p.stockProducto,
                        IdCategoria = p.categoriaID,
                        Costo = p.costoProducto,
                        Id = p.productoID
                    });
            }
            catch (Exception ex)
            {                
                throw new ApplicationException("Error al consultar los productos.");
            }
        }
    }
}
