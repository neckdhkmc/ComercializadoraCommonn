using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.DTO
{
    public class UsuariosDTO
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string NickName { get; set; }
        public string Pasword { get; set; }
        public string NumEmpleado { get; set; }
        public string Email { get; set; }
        public string Telfono { get; set; }
        public string tokenRecovery { get; set; }

        public int IdRol { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdStatus { get; set; }
    }
}
