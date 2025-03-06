using ConsumeWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumeWS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }       

        public ActionResult Speech() 
        {
            ViewBag.Message = "Asesor ";
            return View();
        }

        [HttpPost]
        public ActionResult Speech(MPersonaClientes cliente)
        {

            ViewBag.Message = "Asesor ";
            return View();
        }
    }
}