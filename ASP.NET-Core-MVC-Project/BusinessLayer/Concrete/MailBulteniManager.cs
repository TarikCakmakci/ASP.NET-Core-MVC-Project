using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MailBulteniManager : IMailBulteniService
    {
        IMailBulteniDal _mailBulteniDal;

        public MailBulteniManager(IMailBulteniDal mailbulteniDal)
        {
            _mailBulteniDal = mailbulteniDal;
        }

        public void AddMailBulteni(MailBulteni mailBulteni)
        {
            _mailBulteniDal.Insert(mailBulteni);
        }

    }
}
