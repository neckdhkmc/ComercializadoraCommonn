using PortalAdmin.ServicioCatalagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalAdmin.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListarRoles()
        {
            CatalagosClient obj = new CatalagosClient();
            var lista = obj.ListaRoles().Select(p => new {

                p.IdRol,
                p.NombreRol,
                p.Descripcion
            }).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}