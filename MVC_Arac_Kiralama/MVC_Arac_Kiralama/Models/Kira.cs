using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Arac_Kiralama.Models
{
    public class Kira
    {
        public int ID { get; set; }
        public DateTime AlisTarihi { get; set; }
        public int KiramalaSuresi { get; set; }
        public double ToplamUcret { get; set; }
        public int AracID { get; set; }
        public int MusteriID { get; set; }

        //baglantı
        public virtual Arac Arac { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}