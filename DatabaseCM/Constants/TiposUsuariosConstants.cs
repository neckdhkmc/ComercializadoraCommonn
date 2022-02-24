using DatabaseCM.Models.TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Constants
{
    public class TiposUsuariosConstants
    {

        public static TipoUsuario colaborador { get { return new TipoUsuario() {Nombre ="Colaborador", Descripcion="Este tipo de usuario son los que tienen mas funciones en el sistema" }; } }


        public static TipoUsuario cliente { get { return new TipoUsuario() { Nombre = "Cliente", Descripcion = "Este tipo de usuario solo puede realizar compras en el sistema" }; } }
      
    }
}
