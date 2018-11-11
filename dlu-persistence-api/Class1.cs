using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace dlu_persistence_api
{
    public class Class1
    {

        private DiMPdotNetEntities entities;
        public Class1()
        {
            entities = new DiMPdotNetEntities();
           
        }

        public StamData GetStamdataByBladId(int bladid)
        {

            using (var con = new DiMPdotNetEntities())
            {

                var res = con.tblBladStamdatas.Where(e => e.BladID == bladid).Single();

                return new StamData()
                {
                    Adresse = res.Adresse,
                    Adresse2 = res.Adresse2,
                    AnnonceEmail = res.AnnonceEmail,
                    AnnonceKontrolEmail = res.AnnonceKontrolEmail,
                    BilagsbladeEmail = res.BilagsbladeEmail,
                    BladID = res.BladID,
                    BogholderiEmails = res.BogholderiEmails,
                     BogholderiKontaktperson = res.BogholderiKontaktperson,
                     CVR =  res.CVR,
                     DelOmrådeID = res.DelOmrådeID,
                     DiMPDelOmrådeKode = res.DiMPDelOmrådeKode

                     

                   



                


                    

            };
            }

           
        }
     
    }
}
