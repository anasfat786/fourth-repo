using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        public ActionResult Index()
        {
            List<Emp> listemp = new List<Emp>
            { new Emp { Eid=1,Ename="sam",EDesig="HR",EDOJ=DateTime.Parse("20-12-2020")},
              new Emp { Eid=2,Ename="ram",EDesig="Manager",EDOJ=DateTime.Parse("10-12-2020")},
               new Emp { Eid=7,Ename="zam",EDesig="Manager",EDOJ=DateTime.Parse("10-12-2020")},

            };
            return View(listemp);
        }
    }
}