using Microsoft.EntityFrameworkCore;
using Sazon_Local.Data;
using Sazon_Local.Models;

namespace Sazon_Local.Repositories
{
    public class Repository: IRepository
    {
        private SazonContext context;

        public Repository(SazonContext context)
        {
            this.context = context;
        }

        #region PRODUCTOS
        public async Task<List<Producto>> GetProductosAsync()
        {
            return await this.context.Productos.Include(p => p.Subcategoria).ToListAsync();
        }

        #endregion
        #region FINCAS
        #endregion
        #region DIRECCIONES
        #endregion
        #region CATEGORIAS
        #endregion
        #region SUBCATEGORIAS
        #endregion
        #region PEDIDOS
        #endregion
        #region DETALLES PEDIDO
        #endregion
        #region PAGOS
        #endregion

    }
}
