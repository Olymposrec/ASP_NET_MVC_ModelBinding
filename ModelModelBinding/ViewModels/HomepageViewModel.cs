using ModelModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelModelBinding.ViewModels
{
    public class HomepageViewModel
    {
        public Person kisiNesnesi { get; set; }
        public Adres adresNesnesi { get; set; }
    }
}