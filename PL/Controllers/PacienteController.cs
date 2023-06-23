using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult GetAll()
        {
         
            ML.Paciente paciente = new ML.Paciente();
            
            

            return View(paciente);
        }
    }
}