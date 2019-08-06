using System;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{
    public class SupportBilagDao: IDisposable
    {

        private DiMPdotNetDevEntities _entities;

        public SupportBilagDao()
        {
            _entities = new DiMPdotNetDevEntities();
            
        }


        public string GetSupportBilagByMedieId(int medieId)
        {

            try
            {
                var res = from sb in _entities.tblSupportBilags
                    where sb.MedieplanNr == medieId
                    select new
                    {
                        sb.MedieplanNr, sb.Bilagsblade, sb.Fakturering, sb.Overskrift, sb.BilagsbladeAtt, sb.IndrykningsUge, sb.LøbendeOrdre,
                        sb.SammeMateriale, sb.BemærkningTilBlade, sb.BemærkningTilSupport, sb.BilagsBladeTil, sb.MaterialeFølgerFra, sb.MaterialeGodtgørelseTil,
                        sb.BilagsBladeTilAdresse, sb.BilagsBladeTilNavn, sb.BrugMaterialeFraUge, sb.KunForhandlerBundForskellig, sb.MaterialeFølgerFraLeverandør,
                        sb.BilagsBladeTilPostNr, sb.BureauOrdresedlerLiggerIIndbakke
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetSupportBilagByMedieId", e.InnerException);
            }
            
        }

        public Task<int> CreateOrUpdate(tblSupportBilag tblSupportBilag)
        {
            try
            {
                _entities.tblSupportBilags.AddOrUpdate(tblSupportBilag);

                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new  FormattedDbEntityValidationException(e.InnerException);
            }
          
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}