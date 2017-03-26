﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Arac_Kiralama.Models
{
    public enum Aractipi
    {
        otomobil = 0,
        Motorsiklet = 0,
        Ticari = 2
    }
    public class Arac
    {
        public int ID { get; set; }
        public string Plaka { get; set; }
        public int Yas { get; set; }
        public Aractipi Tip { get; set; }
        public double GunlukUcret { get; set; }
        public string Kiralandimi { get; set; }
        public string Silindimi { get; set; }

        public int MarkaID { get; set; }
        public int ModelID { get; set; }


    }
}