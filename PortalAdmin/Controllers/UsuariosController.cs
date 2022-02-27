using PortalAdmin.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PortalAdmin.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public async Task<Uri> Agregar(UsuariosDTO model)
        {
            model.IdRol = 1;
            model.IdTipoUsuario = 1;
            model.IdStatus = 1;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HTTP POST
                HttpResponseMessage postTask = await client.PostAsJsonAsync<UsuariosDTO>("api/Users", model);
                //postTask.Wait();


                return postTask.Headers.Location;

            }
        }
    }
}