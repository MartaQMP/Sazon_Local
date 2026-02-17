using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("FINCAS")]
    public class Finca
    {
        [Key]
        [Column("ID_FINCA")]
        public int IdFinca { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("MUNICIPIO")]
        public string Municipio { get; set; }

        [Column("PROVINCIA")]
        public string Provincia { get; set; }

        [Column("LATITUD")]
        public double Latitud { get; set; }

        [Column("LONGITUD")]
        public double Longitud { get; set; }

        [Column("ID_USUARIO")]
        public int IdAgricultor { get; set; }

        [ForeignKey("IdAgricultor")]
        public virtual Usuario Agricultor { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
