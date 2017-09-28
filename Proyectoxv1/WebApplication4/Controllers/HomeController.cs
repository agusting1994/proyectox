using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Datos;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Universidades()
        {
            ViewBag.Message = "Selecciona la Universidad.";
            using (var db = new ModelContext())
            {
                return View(db.universidad.ToList());
            }
        }

        public ActionResult Carreras(int id)
        {
            using (var db = new ModelContext())
            {
                return View(db.carrera.Where(a=> a.iduniversidad == id).ToList());
            }
        }
        public ActionResult Cursos(int idcar, int iduniv )
        {
            ViewBag.carrera = idcar;
            using (var db = new ModelContext())
            {
                return View(db.curso.Where(a => a.iduniversidad == iduniv && a.idcarrera== idcar).ToList());
            }
        }

        public ActionResult Informacion(int id)
        {
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    else
            //    {
            using (var db = new ModelContext())
                {
                    return View(db.curso.Where(a => a.idcurso == id).ToList());
                }
            //}
          
        }

        public ActionResult Compra()
        {
            int id = 12;
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.aut = "Autenticado";
                using (var db = new ModelContext())
                {
                    return View(db.curso.Where(a => a.idcurso == id).ToList());
                }
            }
            else
            {
                ViewBag.aut = "No autenticado";
                using (var db = new ModelContext())
                {
                    return View(db.curso.Where(a => a.idcurso == id).ToList());
                }
            }
            
        }
    }
}