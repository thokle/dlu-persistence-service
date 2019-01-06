using AutoMapper;
using dlu_persistence_api.models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace dlu_persistence_api.mapper
{
    public class AutoMaperUtil
    {
        public static StamData ConvertFromTblStamBladEntity(tblBladStamdata  tblBladStamdata) {
            var config = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tblBladStamdata, StamData>();                
                cfg.CreateMap<tblDage, Dage>();
                cfg.CreateMap<tblDage, Dage1>();
                cfg.CreateMap<tblDelOmråde, DelOmraade>();
                cfg.CreateMap<tblGeoKode, GeoKode>();
                cfg.CreateMap<tblHovedGruppe, HovedGruppe>();
                cfg.CreateMap<tblPostNr, PostNr>();
                cfg.CreateMap<tblRegion, Region>();
                cfg.CreateMap<ICollection<tblMedieplanLinjer>, Collection<MedieplanLinjer>>();
                cfg.CreateMap<ICollection<tblPriser>, Collection<Prisers>>();
                cfg.CreateMap<List<tblPrislisterPrBladPrÅr>, List<PrislisterPrBladÅr>>();
                cfg.CreateMap<List<tblPrislisterPrBladPrUge>, List<PrislisterPrBladPrUges>>();              

               
            });
          
            var mapper = config.CreateMapper();
            return mapper.Map<tblBladStamdata, StamData>(tblBladStamdata);               
            
                }


        public static tblBladStamdata ConvertFromnStamData(StamData stamData)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<StamData, tblBladStamdata>();
                cfg.CreateMap<Dage, tblDage>();
                cfg.CreateMap<Dage1, tblDage>();            
                cfg.CreateMap<DelOmraade, tblDelOmråde>();
                cfg.CreateMap<GeoKode, tblGeoKode>();
                cfg.CreateMap<HovedGruppe, tblHovedGruppe>();
                cfg.CreateMap<PostNr, tblPostNr>();
                cfg.CreateMap<Region, tblRegion>();
                cfg.CreateMap<List<MedieplanLinjer>, List<tblMedieplanLinjer>>();
                cfg.CreateMap<List<Prisers>, List<tblPriser>>();
                cfg.CreateMap<List<PrislisterPrBladÅr>, List<tblPrislisterPrBladPrÅr>>();
                cfg.CreateMap<List<PrislisterPrBladPrUges>, List<tblPrislisterPrBladPrUge>>();
            });

            var mapper = config.CreateMapper();
            return mapper.Map<StamData, tblBladStamdata>(stamData);
        }

        
        public static List<StamData> ConvertFromTblBladEntitie(List<tblBladStamdata> tblBladStamdatas)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tblBladStamdata, StamData>();
                cfg.CreateMap<tblDage, Dage>();
                cfg.CreateMap<tblDage, Dage1>();
                cfg.CreateMap<tblDelOmråde, DelOmraade>();
                cfg.CreateMap<tblGeoKode, GeoKode>();
                cfg.CreateMap<tblHovedGruppe, HovedGruppe>();
                cfg.CreateMap<tblPostNr, PostNr>();
                cfg.CreateMap<tblRegion, Region>();
                cfg.CreateMap<List<tblMedieplanLinjer>, List<MedieplanLinjer>>();
                cfg.CreateMap<List<tblPriser>, List<Prisers>>();
                cfg.CreateMap<List<tblPrislisterPrBladPrÅr>, List<PrislisterPrBladÅr>>();
                cfg.CreateMap<List<tblPrislisterPrBladPrUge>, List<PrislisterPrBladPrUges>>();


            });

            var mapper = config.CreateMapper();
            return mapper.Map<List<tblBladStamdata>, List<StamData>>(tblBladStamdatas);
  
        }


        public static MediePlan ConvertFromTbleMdiePlan(tblMedieplan tblMedieplan)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tblDPKulør, DPBukær>();
                cfg.CreateMap<tblMedieplanNr, MediePlanNr>();
                cfg.CreateMap<tblPlacering, Placering>();

            });

            var mapper = config.CreateMapper();
            return mapper.Map<tblMedieplan, MediePlan>(tblMedieplan);  

        }

        public static tblMedieplan ConvertFromMediePlan(MediePlan mediePlan)
        {

            var config = new MapperConfiguration(cfg =>
             {
                 cfg.AllowNullCollections = true;
                 cfg.CreateMap<DPBukær, tblDPKulør>();
                 cfg.CreateMap<MediePlanNr, tblMedieplanNr>();
                 cfg.CreateMap<Placering, tblPlacering>();
             });

            var mapper = config.CreateMapper();
            return mapper.Map<MediePlan, tblMedieplan>(mediePlan);
        }

        public static List<Prisers> ConvertblPriser(ICollection<tblPriser> tblPrisers)
        {
            var config = new MapperConfiguration(cfg => { });

            var mapper = config.CreateMapper();
            return mapper.Map<ICollection<tblPriser>, List<Prisers>>(tblPrisers);
        }    
        
    }


}

/*
 *   
        public virtual tblDPKulør tblDPKulør { get; set; }
        public virtual tblMedieplanNr tblMedieplanNr { get; set; }
        public virtual tblPlacering tblPlacering { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMedieplanLinjer> tblMedieplanLinjers { get; set; }
      
      
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrislisterPrBladPrÅr> tblPrislisterPrBladPrÅr { get; set; }
*/
