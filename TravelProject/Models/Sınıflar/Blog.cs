using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string baslik { get; set; }
        public DateTime tarih { get; set; }
        public string aciklama { get; set; }
        public string blogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}