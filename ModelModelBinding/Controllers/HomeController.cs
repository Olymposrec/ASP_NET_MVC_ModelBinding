using ModelModelBinding.Models;
using ModelModelBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            Person kisi = new Person();
            kisi.Ad = "Melih";
            kisi.soyad = "Akkose";
            kisi.yas = 21;
            kisi.mail = "melihakkse@hotmail.com";
            
            Adres adres = new Adres();
            adres.il = "İzmir";
            adres.ilce = "Karabağlar";
            HomepageViewModel mod = new HomepageViewModel();
            mod.kisiNesnesi = kisi;
            mod.adresNesnesi = adres;
            return View(mod);
        }
        [HttpPost]
        public ActionResult Homepage(HomepageViewModel kisi)
        {
            return View( kisi);
        }
    }
}