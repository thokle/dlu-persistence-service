﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{
    public class AktiveAviserTIlGridDao
    {
        private DiMPdotNetDevEntities entities;

        public AktiveAviserTIlGridDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public string GetAllAvisetTilGrid()
        {
            try
            {
                var res = from d in entities.UgeaviserTilGrids
                          select new AktiveAviserModel
                          {

                              Adresse = d.Adresse,
                              Adresse2 = d.Adresse2,
                              BladID = d.BladID,
                              CVR = d.CVR,
                              DaekningsGrad = d.DækningsGrad,
                              DagNavn = d.DagNavn,
                              DelOmraadeNavn = d.DelOmrådeNavn,
                              GeoKodeNavn = d.GeoKodeNavn,
                              GruppeNavn = d.GruppeNavn,
                              HovedGruppeNavn = d.HovedGruppeNavn,
                              Kontaktperson = d.Kontaktperson,
                              MaterialedeadlineRubrik = d.MaterialedeadlineRubrik,
                              MaterialedeadlineTekst = d.MaterialedeadlineTekst,
                              Navn = d.Navn,
                              Navn2 = d.Navn2,
                              Oplag = d.Oplag,
                              OrdredeadlineRubrik = d.OrdredeadlineRubrik,
                              OrdredeadlineTekst = d.OrdredeadlineTekst,
                              PostBy = d.PostBy,
                              PostNr = d.PostNr,
                              RegionNavn = d.RegionNavn
                          };

       
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            
            catch (FormattedDbEntityValidationException  e)
            {

                throw new Exception(e.Message);
            }
        }

        public string getAktivAvisByNavn(string navn)
        {
            try
            {
                var res = entities.UgeaviserTilGrids.Where(v => v.PostBy.ToLower().Contains(navn) || v.PostBy.ToLower().StartsWith(navn) || v.PostBy.ToLower().EndsWith(navn)).Select(d => new AktiveAviserModel
                {
                    Adresse = d.Adresse,
                    Adresse2 = d.Adresse2,
                    BladID = d.BladID,
                    CVR = d.CVR,
                    DaekningsGrad = d.DækningsGrad,
                    DagNavn = d.DagNavn,
                    DelOmraadeNavn = d.DelOmrådeNavn,
                    GeoKodeNavn = d.GeoKodeNavn,
                    GruppeNavn = d.GruppeNavn,
                    HovedGruppeNavn= d.HovedGruppeNavn,
                    Kontaktperson = d.Kontaktperson,
                    MaterialedeadlineRubrik = d.MaterialedeadlineRubrik,
                    MaterialedeadlineTekst = d.MaterialedeadlineTekst,
                    Navn = d.Navn,
                    Navn2 = d.Navn2,
                    Oplag = d.Oplag,
                    OrdredeadlineRubrik = d.OrdredeadlineRubrik,
                    OrdredeadlineTekst = d.OrdredeadlineTekst,
                    PostBy = d.PostBy,
                    PostNr = d.PostNr,
                    RegionNavn = d.RegionNavn
                });

                var array = res.ToArray<AktiveAviserModel>();
                var data = new Data(array.Length);
                var i = 0;
                foreach (AktiveAviserModel a in array)
                {
                    data.data[i] = a;
                    i++;
                }
                return JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented });
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.HelpLink);
            }
        }

        public string getAktiveAvisByDaekningGrad(int daek)
        {
            try
            {
                var res = from d in entities.UgeaviserTilGrids
                          where d.DækningsGrad == daek
                          select new AktiveAviserModel
                          {
                              Adresse = d.Adresse,
                              Adresse2 = d.Adresse2,
                              BladID = d.BladID,
                              CVR = d.CVR,
                              DaekningsGrad = d.DækningsGrad,
                              DagNavn = d.DagNavn,
                              DelOmraadeNavn = d.DelOmrådeNavn,
                              GeoKodeNavn = d.GeoKodeNavn,
                              GruppeNavn = d.GruppeNavn,
                              HovedGruppeNavn = d.HovedGruppeNavn,
                              Kontaktperson = d.Kontaktperson,
                              MaterialedeadlineRubrik = d.MaterialedeadlineRubrik,
                              MaterialedeadlineTekst = d.MaterialedeadlineTekst,
                              Navn = d.Navn,
                              Navn2 = d.Navn2,
                              Oplag = d.Oplag,
                              OrdredeadlineRubrik = d.OrdredeadlineRubrik,
                              OrdredeadlineTekst = d.OrdredeadlineTekst,
                              PostBy = d.PostBy,
                              PostNr = d.PostNr,
                              RegionNavn = d.RegionNavn
                          };
               var array =  res.ToArray <AktiveAviserModel> ();
                var data = new Data(array.Length);
                var i = 0;
                foreach(AktiveAviserModel a in array)
                {
                    data.data[i] = a;
                    i++;
                }
                return JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented });
            }
            catch (FormattedDbEntityValidationException e )
            {

                throw new Exception(e.HelpLink);
            }
        }

    }

    internal class Data
    {
        public Data(int size)
        {
            data = new AktiveAviserModel[size];
        }
        public AktiveAviserModel[] data { get; set; }
    }
    internal class AktiveAviserModel
    {
        public string Adresse { get; set; }
        public string Adresse2 { get; set; }
        public int BladID { get; set; }
        public string CVR { get; set; }
        public int? DaekningsGrad { get; set; }
        public string DagNavn { get; set; }
        public string DelOmraadeNavn { get; set; }
        public string GeoKodeNavn { get; set; }
        public string GruppeNavn{ get; set; }
        public string HovedGruppeNavn { get; set; }
        public string Kontaktperson { get; set; }
        public string MaterialedeadlineRubrik { get; set; }
        public string MaterialedeadlineTekst { get; set; }
        public string Navn { get; set; }
        public string Navn2 { get; set; }
        public int? Oplag { get; set; }
        public string OrdredeadlineRubrik { get; set; }
        public string OrdredeadlineTekst{ get; set; }
        public string PostBy { get; set; }
        public int? PostNr { get; set; }
        public string RegionNavn { get; set; }
    }
}