using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using dlu_persistence_api.models;
namespace dlu_persistence_api.mapper
{
    public class AutoMaperUtil
    {
        public static StamData ConvertFromTblStamBladEntity(tblBladStamdata  tblBladStamdata) {
            var config = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tblBladStamdata, StamData>();
                
               cfg.CreateMap<tblDage[],  ICollection<Dage> >(tblBladStamdata.tblDage);
            });
          
            var mapper = config.CreateMapper();
            return mapper.Map<tblBladStamdata, StamData>(tblBladStamdata);               
            
                }


         private  ICollection<tblDage>  createDage(tblDage  dage)
         
    


    }

}
