using System;
using System.Collections.Generic;
using System.Linq;

namespace dlu_persistence_api.daos
{
    public class ViewBookingListeDao
    {
        private DiMPdotNetDevEntities _entities;

        public ViewBookingListeDao()
        {
            _entities = new DiMPdotNetDevEntities();

        }

        public List<BookingListe> GetAllBookings()
        {
            try
            {
                return _entities.viewBookingListes.Select(liste => new BookingListe()
                {
                    MedieplanNr = liste.MedieplanNr,
                    Version = liste.Version,
                    AnnoncørNo_ = liste.AnnoncørNo_,

                    BureauNo_ = liste.BureauNo_,
                    Format = liste.Format,
                    AntalFarver = liste.AntalFarver,
                    IndrykningsUge = liste.IndrykningsUge,
                    SamletPris = liste.SamletPris,
                    KonsulentCode = liste.KonsulentCode,
                    IndrykningsÅr = liste.IndrykningsÅr

                }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public List<BookingListe> GetBookingBetweenWeeks(int fra, int til)
        {
            try
            {
                return _entities.viewBookingListes
                    .Where(liste => liste.IndrykningsUge > fra && liste.IndrykningsUge <= til).Select(liste =>
                        new BookingListe()
                        {
                            MedieplanNr = liste.MedieplanNr,
                            Version = liste.Version,
                            AnnoncørNo_ = liste.AnnoncørNo_,

                            BureauNo_ = liste.BureauNo_,
                            Format = liste.Format,
                            AntalFarver = liste.AntalFarver,
                            IndrykningsUge = liste.IndrykningsUge,
                            SamletPris = liste.SamletPris,
                            KonsulentCode = liste.KonsulentCode,
                            IndrykningsÅr = liste.IndrykningsÅr

                        }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }

    public class BookingListe
    {
        public int MedieplanNr { get; set; }
        public short Version { get; set; }
        public string AnnoncørNo_ { get; set; }
        public string BureauNo_ { get; set; }
        public string Format { get; set; }
        public byte AntalFarver { get; set; }
        public byte IndrykningsUge { get; set; }
        public decimal SamletPris { get; set; }
        public string KonsulentCode { get; set; }
        public short IndrykningsÅr { get; set; }
    }
}