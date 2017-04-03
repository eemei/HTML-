using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using CityMizzueMVC.Models;

namespace CityMizzueMVC.Controllers
{
    public class MenShoesController : Controller
    {
        // GET: MenShoes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DispalyShoes()
        {
            List<Men> listuser = new List<Men>();
            Men shoesOne = new Men();
            //Men shoesTwo = new Men();
            shoesOne.desc = "Calvin Klein Jeans Zeus discount：";
            shoesOne.discount = "50%";
            shoesOne.pictureLocation = "http://a3.zassets.com/images/z/4/0/5/3/1/8/4053187-p-MULTIVIEW.jpg";
            shoesOne.address = "http://a3.zassets.com/images/z/4/0/5/3/1/8/4053187-p-MULTIVIEW.jpg";
            shoesOne.alt = "Calvin Klein Jeans Zeus";
            shoesOne.originalPrice = "RM700.00";
            shoesOne.AfterDiscount = "RM350.00";
            listuser.Add(shoesOne);

            shoesOne = new Men();
            shoesOne.desc = "Clarks Becken Plain discount：";
            shoesOne.discount="50%";
            shoesOne.pictureLocation = "http://a3.zassets.com/images/z/3/8/1/7/1/9/3817190-p-MULTIVIEW.jpg";
            shoesOne.address="http://a3.zassets.com/images/z/3/8/1/7/1/9/3817190-p-MULTIVIEW.jpg";
            shoesOne.alt="Clarks Becken Plain";
            shoesOne.originalPrice= "RM640.00";
            shoesOne.AfterDiscount = "RM320.00";
            listuser.Add(shoesOne);

            shoesOne = new Men();
            shoesOne.desc = "adidas Cloudfoam discount：";
            shoesOne.discount = "50%";
            shoesOne.pictureLocation = "http://a1.zassets.com/images/z/3/8/1/0/2/7/3810277-p-MULTIVIEW.jpg";
            shoesOne.address = "http://a1.zassets.com/images/z/3/8/1/0/2/7/3810277-p-MULTIVIEW.jpg";
            shoesOne.alt = "adidas";
            shoesOne.originalPrice = "RM380.00";
            shoesOne.AfterDiscount = "RM140.00";
            listuser.Add(shoesOne);
            return View(listuser.ToList()); // passing data to view
        }
    }
}