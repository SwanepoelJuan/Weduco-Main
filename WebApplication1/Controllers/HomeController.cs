using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = @"Wedoco was founded in June 2017 and our goal was clear to change the way companies receive web solutions and support
                                We are all about leading web solutions and support for our clients that certifies product satisfaction.
                                Wedoco offers a comprehensive one - stop solution that is affordable and optimized for small and big businesses to meet all their website requirements.
                                Wedoco's development team visits our clients and consults them directly to achieve the highest understanding of the owner's goals and needs.
                                Wedoco's design and development team then develops the web solution in-house for our client and shows the owner the progress as it is completed.In less than no time, our clients have fully interactive websites with there own domains, amazing layouts, and animations.
                                Our Web solutions are SEO optimized and efficient this ensures that our client's website shows up first when searched for and helps with responsiveness and overall exposure 
                                See our product and services section for more information or contact us and will get back to you.";
  
            return View();
        }
    }
}