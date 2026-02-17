using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("CARRITO_ITEMS")]
    public class Carrito
    {
        [Key]
        [Column("ID_CARRITO")]
        public int IdCarrito { get; set; }

        [Column("CANTIDAD", TypeName = "decimal(10, 2)")]
        public decimal Cantidad { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
    }
}
