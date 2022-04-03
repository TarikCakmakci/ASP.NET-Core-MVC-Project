using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Models
{
    public class EgitimBilgileri
    {
        public EgitimBilgileri()
        {

        }
        [Key]
        public string Universite { get; set; }

        public string Fakulte { get; set; }

        public string Bolum { get; set; }

        public char Sinif { get; set; }

    }
}
