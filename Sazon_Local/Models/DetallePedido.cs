using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("DETALLE_PEDIDOS")]
    public class DetallePedido
    {
        [Key]
        [Column("ID_DETALLE")]
        public int IdDetalle { get; set; }

        [Column("CANTIDAD")]
        public int Cantidad { get; set; }

        [Column("PRECIO_UNITARIO", TypeName = "decimal(10, 2)")]
        public decimal PrecioUnitario { get; set; }

        [Column("ID_PEDIDO")]
        public int IdPedido { get; set; }

        [ForeignKey("IdPedido")]
        public virtual Pedido Pedido { get; set; }

        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

    }
}
