using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team

        public ActionResult Team()
        {
            ViewBag.Message = "These are the Founders of WeDoCo";
            ViewBag.NardusMessage = @"I started Wedoco Web Solutions with a few business partners and investors as there was a
                high demand for reliable dynamic web solutions for small to medium businesses in the area.
                As I have worked on numerous projects over the years while studying.
                I have found that there are so many businesses that don't have the support that is needed to have an 
                online presence that is productive and that contributes to the business's growth and expansion.
                This is why I started Wedoco to help our clients get great online products and services to optimize
                their marketing, sales and overall exposure.";
            ViewBag.CoetzeeMessage = "Creating is what life is all about";

            return View();
        }
    }
}