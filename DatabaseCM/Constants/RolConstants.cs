using DatabaseCM.Models.TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Constants
{
    public class RolConstants
    {
        public static Rol Super { get { return new Rol() { NombreRol = "Super", Descripcion = "Tiene todos los permisos del sistema", IdEstatus = 1 }; } }

        public static Rol Gerente { get { return new Rol() { NombreRol = "Gerente", Descripcion = "Solo tiene Acceso a la mayore de las funciones del sistema", IdEstatus = 1 }; } }

        public static Rol Cajero { get { return new Rol() { NombreRol = "Cajero", Descripcion = "Solo puede realizar ventas", IdEstatus = 1 }; } }

        public static Rol Provedor { get { return new Rol() { NombreRol = "Provedor", Descripcion = "Solo podras recibir peticiones de mercancia", IdEstatus = 1 }; } }
 
    
    }
}
