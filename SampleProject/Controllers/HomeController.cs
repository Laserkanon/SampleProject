using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            Thread workerThread;



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


                for (var b = 0; b < 10; b++)
                {
                    IntPtr pointer = Marshal.AllocHGlobal(1024);
                }

            return View();
        }
    }
}
