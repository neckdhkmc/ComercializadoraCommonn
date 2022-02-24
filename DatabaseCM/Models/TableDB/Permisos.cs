using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
    public class Permisos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermiso { get; set; }
        public string NombrePermiso { get; set; }
        public string Descripcion { get; set; }
        public string Accion { get; set; }
        public string Controlador { get; set; }
        [Required]
        [ForeignKey("estatus")]
        public int IdEstatus { get; set; }

        //adicionales

        public virtual estatus estatus { get; set; }

    }
}
