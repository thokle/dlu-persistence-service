using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF_sql_services;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class SendTilWebService
    {
        private SendTilWebDao sendTil;

        public SendTilWebService()
        {
            sendTil = new SendTilWebDao();
        }
        public int GetAviserTilWeb()
        {
           return sendTil.GetAviserTilWeb();
        }

        public List<SendTilWeb> GetBladeTilWeb()
        {
            return sendTil.GetBladeTilWeb();
        }

     

        public List<SendTIlWebBladDaekning> GetBladDaeknbingByBladId(int bladid)
        {
            return sendTil.GetBladDaeknbingByBladId(bladid);
        }

        public int UpdateDækningstekst(int BladID, string dækingtekst)
        {
            return sendTil.UpdateDækningstekst(BladID, dækingtekst);
        }

        public int UpdateTlf(string tlf, int bladid)
        {
            return sendTil.UpdateTlf(tlf, bladid);
        }

        public List<BladMMPris> GetBladMMPris(int år, int bladid, string prislistenavn, int placeringsid)
        {
            return sendTil.GetBladMMPris(år, bladid, prislistenavn, placeringsid);
        }

        public List<BladFarvePris> GetBladFarvePris(int år, int bladid, string prislistenavn)
        {
            return sendTil.GetBladFarvePris(år, bladid, prislistenavn);
        }

        public List<BladFarve4Pris> GetBladFarve4Pris(int år, int bladid, string prislistenavn)
        {
            return sendTil.GetBladFarve4Pris(år, bladid, prislistenavn);
        }

        public List<BladFarveMin> GetBladFarveMin(int år, int bladid, string prislistenavn)
        {

            return sendTil.GetBladFarveMin(år, bladid, prislistenavn);
        }


        public List<BladFarve4Min> GetBladFarve4Min(int år, int bladid, string prislistenavn)
        {
            return sendTil.GetBladFarve4Min(år, bladid, prislistenavn);
        }

        public List<BladFarveMax> GetBladBladFarveMax(int år, int bladid, string prislistenavn)
        {
            return sendTil.GetBladBladFarveMax(år, bladid, prislistenavn);
        }

        public List<BladFarve4Max> GetBladBladFarve4Max(int år, int bladid, string prislistenavn)
        {
            return sendTil.GetBladBladFarve4Max(år, bladid, prislistenavn);
        }
    }
}
