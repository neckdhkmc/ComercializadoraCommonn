using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
    public class RolPermiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRolPermiso { get; set; }
        [Required]
        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        [Required]
        [ForeignKey("Permisos")]

        public int IdPermiso { get; set; }

        [Required]
        [ForeignKey("estatus")]
        public int IdEstatus { get; set; }

        //adicionales

        public virtual estatus estatus { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual Permisos Permisos {get; set;}


    }
}
