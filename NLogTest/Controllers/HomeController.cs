using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;

namespace NLogTest.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            logger.Info("This is the first line of home/index method.");

            try
            {
                throw new Exception("This is one badass exception. :)");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "It seems the exception happened. :(");
            }

            logger.Warn("This is your last warning!");
            logger.Fatal("And this is fatal error...");

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
        }
    }
}