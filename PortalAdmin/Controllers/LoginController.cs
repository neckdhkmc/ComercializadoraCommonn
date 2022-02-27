using DatabaseCM.Context;
using DatabaseCM.DTO;
using DatabaseCM.Models.TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PortalAdmin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public string login(UsuariosDTO user)
        {
            string mensaje = "";

            //validacion del modelo

            if (!ModelState.IsValid)
            {
                var query = (from state in ModelState.Values
                             from error in state.Errors
                             select error.ErrorMessage).ToList();
                mensaje += "<ul class='list-group'>";
                foreach (var item in query)
                {
                    mensaje += "<li class='list-group-item'>" + item + "</li>";

                }
                mensaje += "</ul>";

            }
            else
            {

                string nombreUsuario = user.NickName;
                string password = user.Pasword;

                //metodo para cifrar la contraseña
                SHA256Managed sha = new SHA256Managed();
                byte[] byteContra = Encoding.Default.GetBytes(password);
                byte[] byteContraCifrado = sha.ComputeHash(byteContra);
                //la cadena de caracteres se almacena en la variable cadenaContraCifrada
                string cadenaContraCifrada = BitConverter.ToString(byteContraCifrado).Replace("-", "");

                using (var bd = new AplicationDbContext())
                {
                    int numeroVeces = bd.usuarios.Where(p => p.NickName == nombreUsuario
                    && p.Pasword == cadenaContraCifrada).Count();
                    mensaje = numeroVeces.ToString();
                    if (mensaje == "0")
                    {
                        mensaje = "Usuario o contraseña incorrecta";
                    }
                    Usuarios ousuario = bd.usuarios.Where(p => p.NickName == nombreUsuario
                        && p.Pasword == cadenaContraCifrada && p.IdStatus == 1).First();



                }


            }


            return mensaje;


        }

    }
}