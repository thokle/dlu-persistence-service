using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dimp_sql_services.daos;
namespace dimp_sql_services.services
{
   public class MailService
    {
        private MailDao mailDao;

        public MailService()
        {
            mailDao = new MailDao();
        }

        public Task<int> OpretMail(Mail mail)
        {
            return mailDao.OpretMail(mail);
        }
    }
}
