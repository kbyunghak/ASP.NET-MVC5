using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using System.Net;

namespace MvcWebPrimer.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            var path = Server.MapPath("~/Text_Files/");

            var dir = new DirectoryInfo(path);

            var files = dir.EnumerateFiles().Select(f => f.Name);

            return View(files.ToList());
        }
        public ActionResult Content(string fName)
        {
            //DirectoryInfo dinfo = new DirectoryInfo(@"D:\BCIT\4th term\COMP4870-Intranet Palnning & Developmt\MvcWebPrimer20160122\MvcWebPrimer\MvcWebPrimer\Text_Files\");
            //DirectoryInfo dinfo = new DirectoryInfo(@"~\Text_Files\");

            var path = Server.MapPath("~/Text_Files/");
            //FileInfo[] Files = dinfo.GetFiles(fName);
            ViewBag.fileName = path + "" + fName;
            return View();
        }
    }
}