using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
    public class Ventas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int  IdVenta { get; set; }
          

        public DateTime Fecha { get; set; }

        public string Folio { get; set; }

        public int MyProperty { get; set; }

        [Required]
        [ForeignKey("Productos")]
        public int IdProducto { get; set; }
        public int cantidad { get; set; }

        public decimal Importe { get; set; }

        [Required]
        [ForeignKey("Usuarios")]
        public int IdCajero { get; set; }


        //adicionales
        public virtual Productos Productos { get; set; }

        public virtual Usuarios Usuarios { get; set; }


    }
}
