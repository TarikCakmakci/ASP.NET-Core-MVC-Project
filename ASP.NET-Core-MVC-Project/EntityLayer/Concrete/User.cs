using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]

        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string UserSurname { get; set; }

        public int UserPhone { get; set; }

        public string UserAddress { get; set; }

        public string UserMail { get; set; }

        public string UserLinkedin { get; set; }

        public bool UserStatus { get; set; }
    }
}
