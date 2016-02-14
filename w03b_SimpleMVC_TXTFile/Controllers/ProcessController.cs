using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace MvcWebPrimer.Controllers
{
   // [Authorize]
    public class ProcessController : Controller
    {
        //[AllowAnonymous]
        // GET: Process
        public ActionResult Index()
        {
            var processes = Process.GetProcesses();

            var sorted = processes
                .OrderBy(n => n.ProcessName);
                
            return View(sorted.ToList());
        }

        public ActionResult Details(int id)
        {
            var process = Process.GetProcesses()
                .FirstOrDefault(p => p.Id == id);

            return View(process);
        }
    }
}