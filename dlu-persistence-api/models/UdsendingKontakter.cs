using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.models
{
    
    public class UdsendingKontakter
    {

        private DiMPdotNetDevEntities DiMPdotNetDevEntities;

        public UdsendingKontakter()
        {
            DiMPdotNetDevEntities = new DiMPdotNetDevEntities();
          
            KontaktTyper = (from kt in DiMPdotNetDevEntities.tblStambladUdsendingEmailTypers
                            select new StambladUdsendingEmailTyper()
                            {
                                id = kt.id, titel = kt.titel
                            }).ToList();

            KontaktTitlers  = (from t in DiMPdotNetDevEntities.tblKontaktTitlers
                          select new Titler()
                          {
                              Id = t.TitelID , Titel = t.Titel
                          }).ToList(); 
        }
        private int? bladId;
        private int id;
        private string name;
        private string email;
        private string kontaktType;
        private int? telefonnummer;
        private string titel;
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string KontaktType { get => kontaktType; set => kontaktType = value; }
        public int? Telefonnummer { get => telefonnummer; set => telefonnummer = value; }
        public int? BladId { get => bladId; set => bladId = value; }
        public int Id { get => id; set => id = value; }
        public string Titel { get => titel; set => titel = value; }
         public List<StambladUdsendingEmailTyper> KontaktTyper { get; set; }
        public List<Titler>  KontaktTitlers { get; set; }

    }

    public class Titler
    {
        public Titler()
        {
        }

        public int Id { get; set; }
        public string Titel { get; set; }
    }
}
