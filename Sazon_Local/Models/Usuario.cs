using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sazon_Local.Models
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("APELLIDOS")]
        public string Apellidos { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("CONTRASENA")]
        public string Contrasena { get; set; }
        
        [Column("TELEFONO")]
        public string Telefono { get; set; }

        [Column("ID_ROL")]
        public int IdRol { get; set; }

        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; }

        public virtual ICollection<Finca> Fincas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}
