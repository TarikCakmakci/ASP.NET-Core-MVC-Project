using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Models
{
    public class Deneyimler
    {
        public Deneyimler()
        {

        }
        [Key]
        public string Sektor { get; set; }

        public string CalismaSekli { get; set; }

        public string Unvan { get; set; }

        public int Sure { get; set; }

        public string SirketAdi { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }
    }
}
