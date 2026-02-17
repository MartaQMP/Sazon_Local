using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("PRODUCTOS")]
    public class Producto
    {
        [Key]
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("PRECIO_UNIDAD", TypeName = "decimal(10, 2)")] 
        public decimal PrecioUnidad { get; set; }

        [Column("UNIDAD_MEDIDA")]
        public string UnidadMedida { get; set; }

        [Column("STOCK", TypeName = "decimal(10, 2)")]
        public decimal Stock { get; set; }

        [Column("ESTA_ACTIVO")]
        public bool EstaActivo { get; set; }

        [Column("ID_FINCA")]
        public int IdFinca { get; set; }

        [ForeignKey("IdFinca")]
        public virtual Finca Finca { get; set; }

        [Column("ID_SUBCATEGORIA")]
        public int IdSubcategoria { get; set; }

        [ForeignKey("IdSubcategoria")]
        public virtual Subcategoria Subcategoria { get; set; }

        [Column("ID_CATEGORIA")]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }

    }
}
