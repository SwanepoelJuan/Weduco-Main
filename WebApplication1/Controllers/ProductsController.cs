using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {

            return View();
        }
        public ActionResult Web()
        {
            return View();
        }
        public ActionResult Computers()
        {
            return View();
        }
    }
}