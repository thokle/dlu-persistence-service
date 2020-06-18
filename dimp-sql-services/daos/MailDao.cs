using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimp_sql_services.daos
{
    class MailDao
    {
        private dimpSQLEntities dimpSQLEntities;

        public MailDao()
        {
            dimpSQLEntities = new dimpSQLEntities();
        }

        public int OpretMail(Mail mail)
        {
            var tblMail = new tblMail();
            tblMail.Attachfile1 = mail.Attachfile1;
            tblMail.Attachfile2 = mail.Attachfile2;
            tblMail.Body = mail.Body;
            tblMail.SendFrom = mail.SendFrom;
            tblMail.SendTo = mail.SendTo;
            tblMail.Subject = mail.Subject;
            dimpSQLEntities.tblMails.AddOrUpdate(tblMail);
            return dimpSQLEntities.SaveChanges();
        }

        
    }

    public class Mail
    {
        public string Attachfile1 { get;  set; }
        public string Attachfile2 { get;  set; }
        public string Body { get;  set; }
        public string SendFrom { get;  set; }
        public string SendTo { get;  set; }
        public string Subject { get;  set; }
    }
}
