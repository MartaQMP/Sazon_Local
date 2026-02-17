using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("PEDIDOS")]
    public class Pedido
    {
        [Key]
        [Column("ID_PEDIDO")]
        public int IdPedido { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }

        [Column("ESTADO")]
        public string Estado { get; set; }

        [Column("FECHA_PEDIDO")]
        public DateTime FechaPedido { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Cliente { get; set; }

        [Column("ID_DIRECCION_ENTREGA")]
        public int IdDireccion { get; set; }

        [ForeignKey("IdDireccion")]
        public virtual Direccion Direccion { get; set; }

        public virtual ICollection<DetallePedido> DetallesPedido { get; set; }
    }
}
