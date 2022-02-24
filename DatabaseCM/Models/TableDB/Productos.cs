using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
     public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Descuento { get; set; }

        public int existencia { get; set;}
        [Required]
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        public string descripcion{get; set; }
        public string  Marca { get; set; }

        public string CodigoBarras { get; set; }

        public byte imagen { get; set; }

        // adicionales

        public virtual Categoria Categoria { get; set; }

    }
}
