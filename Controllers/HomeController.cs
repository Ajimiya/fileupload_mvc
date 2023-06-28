using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Antlr.Runtime.Misc;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Fileuploader.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
         {
             return View();
         }
         [HttpPost]
         public ActionResult Index(HttpPostedFileBase file)
         {
             string path =Server.MapPath("~/App_Data/File");
             string fileName = path.GetFileName(file.FileName);

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
         }*/
        public ActionResult Upload ()
        {
            return View();
        }

        // POST: FileUpload/Upload
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                
                string fileName = Path.GetFileName(file.FileName);

               
                string path = Path.Combine(Server.MapPath(path: "~/File/"), fileName);
                file.SaveAs(path);

              

                return RedirectToAction("Index");
            }

            
            ViewBag.ErrorMessage = "Please select a file to upload.";
            return View("Index");
        }
    }
}
