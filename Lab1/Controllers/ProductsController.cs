using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        //Get: Products/Details?genre=[value]
        public ActionResult Details(string genre)
        {
            ViewBag.Genre = genre;
            return View();
        }
    }
}