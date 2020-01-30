using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MyApp.Controllers
{
    public class VRController : Controller
    {
        // GET: VR
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WhereToBuy()
        {
            return View();
        }
        public ActionResult ValveIndex()
        {
            return View();
        }
        public ActionResult HTCVive()
        {
            return View();
        }
        public ActionResult OculusRiftS()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WhereToBuy(string headsets)
        {
            var productType = HttpUtility.HtmlEncode(headsets);
            var viewName = "";
            switch (productType)
            {
                case "Oculus: Rift S":
                    viewName = "OculusRiftS"; 
                    break;
                case "":
                    viewName = "WhereToBuy";

                    break;
                case "HTCVive":
                    viewName = "HTCVive"; 
                    break;
                case "Valve Index":
                    viewName = "ValveIndex"; 
                    break;  
                default:
                    viewName = "WhereToBuy";
                    break;
            }
            return View(viewName);
        }
   
    }
}