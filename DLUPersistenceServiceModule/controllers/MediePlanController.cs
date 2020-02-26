using dlu_persistence_api;
using dlu_persistence_api.models;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Newtonsoft.Json;
using System;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanController : NancyModule
    {
        private const bool RunAsync = true;

        public MediePlanController(MediePlanService dao)
        {

            Get("/mediePlan/medieId/{medieId}/{version}", parameters => { return dao.GetMediePlanByNumber(parameters.medieId, parameters.version); });
            Get("/mediePlan/kontaktPerson/{kon taktPerson:string", o => { return dao.GetMediePlanByKontakt(o.kontaktPerson); });
            Get("/mediePlan/tilgrid/{stambladid:int}", p => { return dao.GetAvisTilMediePlan(p.stambladid); });
            Get("/mediePlan/annoncoer/{annoncoer}", p => dao.GetMediePlanByAnnoncoer(p.annoncoer));
            Get("/mediePlan/toolbar/{mediePlan}/{annoncoer}/{bureau}/{fraUge}/{tilUge}/{aar}/{visInAktiveAnnoncer}/{mediePlanCheckBox}/{rtAkCheckBox}/{fakuering}", p => { return dao.findMediePlanToolbar(p.mediePlan, p.annoncoer, p.bureau, p.fraUge, p.tilUge, p.aar, p.visInAktiveAnnoncer, p.mediePlanCheckBox, p.rtAkCheckBox, p.faktuering); });
            Post("/mediePlan/create", o =>
            {
                var stream = Nancy.IO.RequestStream.FromStream(Request.Body).AsString();


                var res = dao.CreateOrUpdateMediePlan(convertFromJson(stream));
                return res;
            });
            Get("/mediePlan/getlatestId", o => Response.AsJson(dao.GetLatestMedienr()));
        }


        private tblMedieplan convertFromJson(string json)
        {
            tblMedieplan tbl = null;
            try
            {
                var res = JsonConvert.DeserializeObject<MediePlanModel>(json);
                tbl = new tblMedieplan();

                tbl.AnnoncørNo_ = res.AnnoncørNo_;
                tbl.AntalFarver = res.AntalFarver;
                tbl.BemærkningTilAnnoncør = res.BemærkningTilAnnoncør;
                tbl.BemærkningTilBlade = res.BemærkningTilBlade;
                tbl.Beskrivelse = res.Beskrivelse;
                tbl.BilagsBladeATT = res.BilagsBladeATT;
                tbl.BilagsBladeTil = res.BilagsBladeTil;
                tbl.BilagsBladeTilAdresse = res.BilagsBladeTilAdresse;
                tbl.BilagsBladeTilNavn = res.BilagsBladeTilNavn;
                tbl.BilagsBladeTilPostNr = res.BilagsBladeTilPostNr;
                tbl.BrugMaterialeFraUge = res.BrugMaterialeFraUge;
                tbl.BureauNo_ = res.BureauNo_;
                tbl.Credit_Reason = res.Credit_Reason;
                tbl.Document_Type = res.Document_Type;

                tbl.DPKulørID = res.DPKulørID;
                tbl.Fakturering = res.Fakturering;
                tbl.Format1 = res.Format1;
                tbl.Format2 = res.Format2;
                tbl.FællesBureauOrdreNr = res.FællesBureauOrdreNr;
                tbl.IndrykningsUge = res.IndrykningsUge;
                tbl.IndrykningsÅr = res.IndrykningsÅr;
                tbl.InfoGodt = res.InfoGodt;
                tbl.KonsulentCode = res.KonsulentCode;
                tbl.Kontaktperson = res.Kontaktperson;
                tbl.KontaktpersonTilhører = res.KontaktpersonTilhører;
                tbl.KunForhandlerBundForskellig = res.KunForhandlerBundForskellig;
                tbl.MaterialeFølgerFra = res.MaterialeFølgerFra;
                tbl.MaterialeFølgerFraLeverandør = res.MaterialeFølgerFraLeverandør;
                tbl.MaterialeGodtgørelseAlle = res.MaterialeGodtgørelseAlle;
                tbl.MaterialeGodtgørelseTil = res.MaterialeGodtgørelseTil;
                tbl.MedieplanNr = res.MedieplanNr;
                tbl.MiljøTillægOpkræves = res.MiljøTillægOpkræves;
                tbl.OpkrævDSVPMiljøTillæg = res.OpkrævDSVPMiljøTillæg;
                tbl.OpkrævFynskeMiljøTillæg = res.OpkrævFynskeMiljøTillæg;
                tbl.OpkrævHelsingørMiljøTillæg = res.OpkrævHelsingørMiljøTillæg;
                tbl.OpkrævJyskeMedierASTillæg = res.OpkrævJyskeMedierASTillæg;
                tbl.OpkrævJyskeMiljøTillæg = res.OpkrævJyskeMiljøTillæg;
                tbl.OpkrævNordjyskeTillæg = res.OpkrævNordjyskeTillæg;
                tbl.OpkrævNorthMiljøTillæg = res.OpkrævNorthMiljøTillæg;
                tbl.OprettetDato = res.OprettetDato;
                tbl.OrdreDato = res.OrdreDato;
                tbl.Overskrift = res.Overskrift;
                tbl.PlaceringID = res.PlaceringID;
                tbl.Previous_Version = res.Previous_Version;
                tbl.RekvisitionsNr = res.RekvisitionsNr;
                tbl.RettelserEfterAnnoncekontrol = res.RettelserEfterAnnoncekontrol;
                tbl.SamletPris = res.SamletPris;
                tbl.SammeBureauOrdreNr = res.SammeBureauOrdreNr;
                tbl.SammeMateriale = res.SammeMateriale;
                tbl.SikkerhedsGodt = res.SikkerhedsGodt;
                tbl.Status = res.Status;
                tbl.TilladFarveSærRabat = res.TilladFarveSærRabat;
                tbl.TilladMmSærRabat = res.TilladMmSærRabat;
                tbl.Version = res.Version;
                tbl.SamletPris = res.SamletPris;
                tbl.WebTillægOpkræves = res.WebTillægOpkræves;
            }
            catch (Exception e)
            {

                throw new Exception(e.HelpLink);
            }




            return tbl;
        }

    }
}
