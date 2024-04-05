using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dropdoen2.Models;

namespace Dropdoen2.Controllers
{
    public class DDController : Controller
    {
        // GET: DD
        public ActionResult Index()
        {
            var dp = new Drop
            {
                Gender = new List<SelectListItem>
                {
                    new SelectListItem {Value="1" ,Text="China"},
                    new SelectListItem {Value="2" ,Text="India"},
                    new SelectListItem {Value="3" ,Text="USA"},
                    new SelectListItem {Value="4" ,Text="Germany"},
                    new SelectListItem {Value="5" ,Text="Russia"}
                }
            };

            return View(dp);
        }
        [HttpPost]
        public ActionResult Index( Drop dp) 
        {
            return RedirectToAction("Index");
        
        }

    }
}