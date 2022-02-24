using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Models.TableDB
{
   public class estatus
    {

        [Key]
        public int IdStatus { get; set; }

        public string NombreEstatus{ get; set; }

        public string Descripcion { get; set; }
    }
}
