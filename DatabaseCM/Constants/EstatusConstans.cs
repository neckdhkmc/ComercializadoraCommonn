using DatabaseCM.Models.TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Constants
{
    public class EstatusConstans
    {
        public static estatus Activo { get { return new estatus() { NombreEstatus = "Activo", Descripcion = "Activa todos los elementos para visualizar en el sistema" }; } }
        public static estatus Inactivo { get { return new estatus() { NombreEstatus = "Inactivo", Descripcion = "Desactiva todos los elementos para no visualizar en el sistema" }; } }
    }
}
