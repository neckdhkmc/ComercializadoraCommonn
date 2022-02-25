using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
   public  class ProvedorProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProvedorProducto { get; set; }
        [Required]
        [ForeignKey("Provedores")]
        public int idProvedor { get; set; }

        [Required]
        [ForeignKey("Productos")]
        public int IdProdcutos { get; set; }

        //adicionales

        public virtual Provedores Provedores { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
