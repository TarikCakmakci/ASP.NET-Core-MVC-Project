using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanici
    {
        public Kullanici()
        {

        }
        [Key]
        public int KimlikID { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public string LinkedinLink { get; set; }


    }
}
