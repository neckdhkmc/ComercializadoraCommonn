using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
   public class Provedores
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProvedor { get; set; }

        public string NombreProvedor { get; set; }

        public string NombreContacto { get; set; }

        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string email { get; set; }

        [Required]
        [ForeignKey("Estatus")]
        public int IdEstatus { get; set; }

        //adicionales

        public virtual estatus Estatus { get; set; }

    }
}
