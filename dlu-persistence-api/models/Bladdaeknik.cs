using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.models;
namespace dlu_persistence_api.models
{
    public class Bladdaeknik
    {
        private DiMPdotNetDevEntities DiMPdotNetDevEntities = new DiMPdotNetDevEntities();
        public Bladdaeknik()
        {
            TblPostNrs = (from d in DiMPdotNetDevEntities.tblPostNrs
                          select new daos.PostNrModel()
                          {
                              Hustande = d.Husstande, PostBy = d.PostBy, PostNr = d.PostNr
                          }).ToList<daos.PostNrModel>();
                
        }
        private int BladID;
        private int Oplag;
        private int DaekningsGrad;
            private int PostNr;
        private string postby;

        public int DaekningsGrad1 { get => DaekningsGrad; set => DaekningsGrad = value; }
        public int PostNr1 { get => PostNr; set => PostNr = value; }
        public int Oplag1 { get => Oplag; set => Oplag = value; }
        public int BladID1 { get => BladID; set => BladID = value; }
        public string Postby { get => postby; set => postby = value; }
        public List<daos.PostNrModel> TblPostNrs { get;  set; }
    }
}
