using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("ROLES")]
    public class Rol
    {
        [Key]
        [Column("ID_ROL")]
        public int IdRol { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
