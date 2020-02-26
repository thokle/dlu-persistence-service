using dlu_persistence_api.exceptions;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace dlu_persistence_api.daos
{
    public class SupportBilagDao : IDisposable
    {

        private DiMPdotNetDevEntities _entities;

        public SupportBilagDao()
        {
            _entities = new DiMPdotNetDevEntities();

        }


        public SupporBillag GetSupportBilagByMedieId(int medieId)
        {

            try
            {
                var res = from sb in _entities.tblSupportBilags
                          where sb.MedieplanNr == medieId
                          select new SupporBillag()
                          {
                              MedieplanNr = sb.MedieplanNr,
                              Bilagsblade = sb.Bilagsblade,
                              Fakturering = sb.Fakturering,
                              Overskrift = sb.Overskrift,
                              BilagsbladeAtt = sb.BilagsbladeAtt,
                              IndrykningsUge = sb.IndrykningsUge,
                              LøbendeOrdre = sb.LøbendeOrdre,
                              SammeMateriale = sb.SammeMateriale,
                              BemærkningTilBlade = sb.BemærkningTilBlade,
                              BemærkningTilSupport = sb.BemærkningTilSupport,
                              BilagsBladeTil = sb.BilagsBladeTil,
                              MaterialeFølgerFra = sb.MaterialeFølgerFra,
                              MaterialeGodtgørelseTil = sb.MaterialeGodtgørelseTil,
                              BilagsBladeTilAdresse = sb.BilagsBladeTilAdresse,
                              BilagsBladeTilNavns = sb.BilagsBladeTilNavn,
                              BrugMaterialeFraUge = sb.BrugMaterialeFraUge,
                              KunForhandlerBundForskellig = sb.KunForhandlerBundForskellig,
                              MaterialeFølgerFraLeverandør = sb.MaterialeFølgerFraLeverandør,
                              BilagsBladeTilPostNr = sb.BilagsBladeTilPostNr,
                              BureauOrdresedlerLiggerIIndbakke = sb.BureauOrdresedlerLiggerIIndbakke
                          };

                return res.SingleOrDefault();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetSupportBilagByMedieId", e.InnerException);
            }

        }

        public int CreateOrUpdate(tblSupportBilag tblSupportBilag)
        {
            try
            {
                _entities.tblSupportBilags.AddOrUpdate(tblSupportBilag);

                return _entities.SaveChanges();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }

        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }

    public class SupporBillag
    {
        public int MedieplanNr { get; set; }
        public byte Bilagsblade { get; set; }
        public byte Fakturering { get; set; }
        public string Overskrift { get; set; }
        public string BilagsbladeAtt { get; set; }
        public string IndrykningsUge { get; set; }
        public string LøbendeOrdre { get; set; }
        public bool SammeMateriale { get; set; }
        public string BemærkningTilBlade { get; set; }
        public string BemærkningTilSupport { get; set; }
        public short BilagsBladeTil { get; set; }
        public byte MaterialeFølgerFra { get; set; }
        public byte MaterialeGodtgørelseTil { get; set; }
        public string BilagsBladeTilAdresse { get; set; }
        public string BilagsBladeTilNavns { get; set; }
        public string BrugMaterialeFraUge { get; set; }
        public bool KunForhandlerBundForskellig { get; set; }
        public string MaterialeFølgerFraLeverandør { get; set; }
        public int BilagsBladeTilPostNr { get; set; }
        public byte BureauOrdresedlerLiggerIIndbakke { get; set; }
    }
}