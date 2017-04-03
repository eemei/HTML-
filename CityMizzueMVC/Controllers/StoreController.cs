using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityMizzueMVC.Models;

namespace CityMizzueMVC.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ViewResult Index()
        {
            return View();
        }
        //
        // GET: /Store/Browse
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        //
        // GET: /Store/Details
        public string Details()
        {
            return "Hello from Store.Details()";
        }
    }
}