using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Models
{
    public class Kimlik
    {
        public Kimlik()
        {

        }
        [Key]
        public long KimlikNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string DogumYeri { get; set; }

        public string Cinsiyet { get; set; }

        public string KayitTarihi { get; set; }

        public string AktivasyonTarihi { get; set; }

        public string ProfilFotografi { get; set; }

        






    }
}
