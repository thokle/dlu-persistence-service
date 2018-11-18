using AutoMapper;
using dlu_persistence_api.models;
using System.Collections.Generic;
namespace dlu_persistence_api.mapper
{
    public class AutoMaperUtil
    {
        public static StamData ConvertFromTblStamBladEntity(tblBladStamdata  tblBladStamdata) {
            var config = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tblBladStamdata, StamData>();                
               cfg.CreateMap<tblDage, Dage>();
                cfg.CreateMap<tblDage, Dage>();
                cfg.CreateMap<tblDage, Dage1>();
                cfg.CreateMap<tblDelOmråde, DelOmraade>();
                cfg.CreateMap<tblGeoKode, GeoKode>();
                cfg.CreateMap<tblHovedGruppe, HovedGruppe>();
                cfg.CreateMap<tblPostNr, PostNr>();
                cfg.CreateMap<tblRegion, Region>();
                cfg.CreateMap<List<tblMedieplanLinjer>, List<MedieplanLinjers>>();
                cfg.CreateMap<List<tblPriser>, List<Prisers>>();
                cfg.CreateMap<List<tblPrislisterPrBladPrÅr>, List<PrislisterPrBladÅr>>();
                cfg.CreateMap<List<tblPrislisterPrBladPrÅr>, List<PrislisterPrBladÅr>>();              

               
            });
          
            var mapper = config.CreateMapper();
            return mapper.Map<tblBladStamdata, StamData>(tblBladStamdata);               
            
                }


         private static  ICollection<Dage>  createDage(tblDage dage)
        {
            var res = new List<Dage>() ;
            res.Add(new Dage() { });
            return res;
        }
         
    


    }

}

/*
 *   
       
      
      
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrislisterPrBladPrÅr> tblPrislisterPrBladPrÅr { get; set; }
*/