using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string kullaniciAdi { get; set; }
        public string mail { get; set; }
        public string yorum { get; set; }
        public int blogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}