﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class VozacPomocna
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public string Jmbg { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public int Godina { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipVozila { get; set; }
       // public string idAuta { get; set; }
    }
}