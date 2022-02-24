using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string NickName { get; set; }
        public string Pasword { get; set; }
        public string NumEmpleado { get; set; }
        public string Email { get; set; }
        public string Telfono { get; set; }
        public string tokenRecovery { get; set; }


        [Required]
        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        [Required]
        [ForeignKey("TipoUsuario")]
        public int IdTipoUsuario { get; set; }
        [Required]
        [ForeignKey("Estatus")]
        public int IdStatus { get; set; }
        //adicionales

        public virtual Rol Rol { get; set; }
        public virtual estatus Estatus { get; set; }

        public virtual TipoUsuario TipoUsuario{get; set;}

    }
}
