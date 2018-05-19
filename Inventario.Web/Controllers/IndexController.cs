using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Inventario.Impl.Productos;
using Inventario.Models;

namespace Inventario.Web.Controllers
{
    public class IndexController : Controller
    {
        IProductosImpl _productosImpl;

        public IndexController()
        {
            _productosImpl = new ProductosImpl();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(ConsultarProductosPorNombre(""));
        }

        public ActionResult CrearProducto(int? id)
        {
            try
            {
                ProductosModel modelo = null;
                if (id > 0)
                {
                    modelo = _productosImpl.ConsultarProductoPorId(id.GetValueOrDefault());
                }
                return View(modelo);
            }
            catch (ApplicationException ae)
            {
                ViewBag.error = ae.Message;
                return View();
            }
        }

        [HttpGet]
        public IEnumerable<ProductosModel> ConsultarProductosPorNombre(string nombre)
        {
            try
            {
                return _productosImpl.ConsultarProductosPorNombre(nombre).ToList();                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public JsonResult ConsultarProductosPorNombreAsync(string nombre)
        {
            try
            {
                var result = _productosImpl.ConsultarProductosPorNombre(nombre);
                return Json(new { result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult CrearProductos(ProductosModel modelo)
        {
            try
            {
                bool guardoCorrectamente;
                if (modelo.Id > 0)
                {
                    //Actualizar producto
                }
                else
                {
                    guardoCorrectamente = _productosImpl.CrearProducto(modelo);
                }                
                return Json(new { guardoCorrectamente = true }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {                
                throw new ApplicationException("Error al crear el producto.");
            }
        }

        [HttpGet]
        public JsonResult ConsultarProductosPorNombreCommand(string nombre)
        {
            try
            {
                var result = _productosImpl.ConsultarProductosPorNombreCommand(nombre);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}