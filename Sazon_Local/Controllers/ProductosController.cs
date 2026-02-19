using Microsoft.AspNetCore.Mvc;
using Sazon_Local.Models;
using Sazon_Local.Repositories;
using System.Threading.Tasks;

namespace Sazon_Local.Controllers
{
    public class ProductosController : Controller
    {
        private IRepository repository;

        public ProductosController(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            List<Producto> productos = await this.repository.GetProductosAsync();
            foreach (var producto in productos)
            {
                if (!string.IsNullOrEmpty(producto.Imagen))
                {
                    producto.Imagen = Path.Combine("images", "products", producto.Imagen); ;
                }
                else
                {
                    string imagenSub = producto.Subcategoria.Imagen;
                    producto.Imagen = Path.Combine("images", "subcategories", imagenSub); ;
                }
            }
            return View(productos);
        }
    }
}
