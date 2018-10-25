using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart_Shop_Store.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProductPageView()
        {
            LinkFile.LinkToSQLContextClassDataContext myContext = new LinkFile.LinkToSQLContextClassDataContext();

            var DataDb = myContext.SelectAllProducts().ToList();
            
            return View(DataDb);
        }
    }
}