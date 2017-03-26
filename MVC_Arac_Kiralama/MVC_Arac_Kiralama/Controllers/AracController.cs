using MVC_Arac_Kiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Arac_Kiralama.Controllers
{
    public class AracController : Controller
    {
        // GET: Arac
        public ActionResult Ekle()
        {
            return View();
        }
        public ActionResult Ekle(Arac arac)
        {

            using (KiraDBContext db= new KiraDBContext())
            {
                var marka = db.Marka.FirstOrDefault(n => n.Isım == arac.MarkaIsim);
            }
            return View();
        }
    }
}