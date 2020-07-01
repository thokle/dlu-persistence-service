using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class ExportFileService
    {

        private ExportFileDao exportFile;

        public ExportFileService()
        {
            exportFile = new ExportFileDao();
        }

        public List<tblHovedEle> GetTblHovedEles()
        {
            return exportFile.GetTblHovedEles();
        }

        public List<tblLaesertalEle> GetTblLaesertalEles()
        {
            return exportFile.GetTblLaesertalEles();
        }

        public List<tblRabatEle> GetTblRabatEles()
        {
            return exportFile.GetTblRabatEles();
        }

        public List<tblTekniskEle> GetTblTekniskEles()
        {
            return exportFile.GetTblTekniskEles();
        }

        public List<PrimaerDaekning> GetPrimaerDaeknings()
        {
            return exportFile.GetPrimaerDaeknings();
        }

        public List<BladXml> GetBladXmls()
        {
            return exportFile.GetBladXmls();
        }

        public List<BladXmlDækningsGrad> GetBladXmlDækningsGrads(int bladid)
        {
            return exportFile.GetBladXmlDækningsGrads(bladid);
        }
    }
}
