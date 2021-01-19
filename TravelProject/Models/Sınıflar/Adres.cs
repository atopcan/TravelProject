using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Sınıflar
{
    public class Adres
    {
        [Key]
        public int Id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string adres { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }
        public string konum { get; set; }
    }
}