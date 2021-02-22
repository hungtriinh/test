using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            string text1 = Request["text1"];
            string text2 = Request["text2"];

            Response.Cookies["ckText1"].Value = text1;
            Response.Cookies["ckText1"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["ckText2"].Value = text2;
            Response.Cookies["ckText2"].Expires = DateTime.Now.AddMinutes(1);



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            string ck1 = Request.Cookies["ckText1"].Value;
            string ck2 = Request.Cookies["ckText2"].Value;
            ViewBag.text1 = ck1;
            ViewBag.text2 = ck2;
            return View();
        }
    }
}