using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF_sql_services.daos
{
   public class AnnonøcerDAO
    {

        private DDFEntities dFEntities1;

        public AnnonøcerDAO()
        {
            dFEntities1 = new DDFEntities();
        }


        public List<Annoncøer> GetAnnoncøer()
        {
            var e = from dluc in dFEntities1.DLU_Contact
                    join br in dFEntities1.DLU_Contact_Business_Relation on dluc.No_ equals br.Contact_No_ into dlucbr
                    from br in dlucbr.DefaultIfEmpty()
                    join
                     cm in dFEntities1.DLU_Contact_Mailing_Group on dluc.No_ equals cm.Contact_No_ into cndluc
                    from cm in cndluc.DefaultIfEmpty()
                    where dluc.Type == 0 & br.Link_to_Table == 1 & br.Business_Relation_Code == "CUST" &  br.No_ != "" & cm.Mailing_Group_Code != "INKATIVE" orderby dluc.Name ascending
                    select new Annoncøer()
                    {
                        Annoncør = dluc.Name,
                        AnnoncørID = dluc.No_,
                        Bill_to_Contact_No_ =   dluc.Bill_to_Contact_No_
                    };

            return e.ToList<Annoncøer>();
        }
    }


    public class Annoncøer
    {
        public string Annoncør { get; internal set; }
        public string AnnoncørID { get; internal set; }
        public string Bill_to_Contact_No_ { get; internal set; }
    }
}
