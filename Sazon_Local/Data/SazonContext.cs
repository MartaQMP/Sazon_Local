using Microsoft.EntityFrameworkCore;
using Sazon_Local.Models;

namespace Sazon_Local.Data
{
    public class SazonContext: DbContext
    {

        public SazonContext(DbContextOptions<SazonContext> options): base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Finca> Fincas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Carrito> CarritoItems { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
