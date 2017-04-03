using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityMizzueMVC.Models;

namespace CityMizzueMVC.Controllers
{
    public class WomenShoesController : Controller
    {
        // GET: WomenShoes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayShoes()
        {
            List<Men> listuser = new List<Men>();
            Men shoes = new Men();
            shoes.desc = "Nine West Nobody discount：";
            shoes.discount = "40%";
            shoes.pictureLocation = "http://a1.zassets.com/images/z/3/8/8/9/9/7/3889972-p-MULTIVIEW.jpg";
            shoes.address = "http://a1.zassets.com/images/z/3/8/8/9/9/7/3889972-p-MULTIVIEW.jpg";
            shoes.alt = "Nine West Nobody";
            shoes.originalPrice = "RM 221.90";
            shoes.AfterDiscount = "RM 133.14";
            listuser.Add(shoes);

            shoes = new Men();
            shoes.desc = "Wedding Stiletto Heel discount：";
            shoes.discount = "62%";
            shoes.pictureLocation = "http://a1.zassets.com/images/z/1/0/4/6/7/4/1046740-p-MULTIVIEW.jpg";
            shoes.address = "http://a1.zassets.com/images/z/1/0/4/6/7/4/1046740-p-MULTIVIEW.jpg";
            shoes.alt = "Nine West Nobody1";
            shoes.originalPrice = "RM270.70";
            shoes.AfterDiscount = "RM102.86";
            listuser.Add(shoes);

            shoes = new Men();
            shoes.desc = "Reef Krystal Star Sandal discount：";
            shoes.discount = "20%";
            shoes.pictureLocation = "http://a3.zassets.com/images/z/1/0/6/0/8/9/1060890-p-MULTIVIEW.jpg";
            shoes.address = "http://a3.zassets.com/images/z/1/0/6/0/8/9/1060890-p-MULTIVIEW.jpg";
            shoes.alt = "Nine West Nobody1";
            shoes.originalPrice = "RM30.90";
            shoes.AfterDiscount = "RM24.72";
            listuser.Add(shoes);

            shoes = new Men();
            shoes.desc = "Ralph Lauren Cecilia Sandal discount：";
            shoes.discount = "30%";
            shoes.pictureLocation = "http://a2.zassets.com/images/z/3/5/2/9/6/2/3529624-p-MULTIVIEW.jpg";
            shoes.address = "displayShoesDetail.htm";
            shoes.alt = "office wear";
            shoes.originalPrice = "RM120.00";
            shoes.AfterDiscount = "RM84.00";
            listuser.Add(shoes);

            shoes = new Men();
            shoes.desc = "Kate Spade Heel discount：";
            shoes.discount = "20%";
            shoes.pictureLocation = "http://a1.zassets.com/images/z/3/9/5/9/3/3/3959332-p-MULTIVIEW.jpg";
            shoes.address = "http://a1.zassets.com/images/z/3/9/5/9/3/3/3959332-p-MULTIVIEW.jpg";
            shoes.alt = "kate spade heel";
            shoes.originalPrice = "RM600.00";
            shoes.AfterDiscount = "RM480.00";
            listuser.Add(shoes);

            shoes = new Men();
            shoes.desc = "Anne Klein Buttons discount：";
            shoes.discount = "20%";
            shoes.pictureLocation = "http://a3.zassets.com/images/z/3/9/7/2/1/4/3972147-p-MULTIVIEW.jpg";
            shoes.address = "http://a3.zassets.com/images/z/3/9/7/2/1/4/3972147-p-MULTIVIEW.jpg";
            shoes.alt = "flat";
            shoes.originalPrice = "RM120.00";
            shoes.AfterDiscount = "RM240.00";
            listuser.Add(shoes);
            return View(listuser.ToList());

        }


    }
}