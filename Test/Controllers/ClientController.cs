using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Test.Models;

namespace Test.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ClientReg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ClientReg(Reg obj) 
        {
            return View(obj);
        }
        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(login obj)
        {
            return View(obj);
        }
    }
}