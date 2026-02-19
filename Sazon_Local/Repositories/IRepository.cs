using Sazon_Local.Models;

namespace Sazon_Local.Repositories
{
    public interface IRepository
    {
        Task<List<Producto>> GetProductosAsync();
    }
}
