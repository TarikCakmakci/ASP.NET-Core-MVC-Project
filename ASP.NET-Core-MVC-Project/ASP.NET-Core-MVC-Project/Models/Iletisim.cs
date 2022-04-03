using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Models
{
    public class Iletisim
    {
        public Iletisim()
        {

        }
        [Key]
        public int CepTelefonNo { get; set; }

        public string Adres { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        public string Mail { get; set; }

        public string WebSayfasi { get; set; }

        public string BlogSayfasi { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Linkedin { get; set; }

        public string Instagram { get; set; }

       
    }
}
