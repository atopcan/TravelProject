using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Sınıflar
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string fotoUrl { get; set; }
        public string aciklama { get; set; }
    }
}