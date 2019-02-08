using System.Threading;
 using dlu_persistence_api;
 using Nancy;
 using  dlu_persistence_api.services;
 using Nancy.ModelBinding;
 namespace DLUPersistenceServiceModule.controllers
 {
     public sealed class MediePlanNrController: NancyModule
     {
         public MediePlanNrController(MediePlanNrService service)
         {
             Get("/medieplannr/{medieplannr:int}", o => { return service.GetMediePlanNrByMedIePlanNr(o.medieplannr); });
             
             Post("/medieplannr/create", o =>
                 {
 
                     var mediePlan = this.Bind<tblMedieplanNr>();
 
                     var res = service.CreateOrUpsateMediePlanNr(mediePlan).GetAwaiter();
 
                  
                    
                         return res.GetResult();
                    
                     
                 } 
                 );
             
         }
     }
 }