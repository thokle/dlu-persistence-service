using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace dlu_persistence_api.daos
{
    public class FejlTekstDao: IDisposable

    {
    private DiMPdotNetEntities _entities;

    public FejlTekstDao()
    {
        using (_entities = new DiMPdotNetEntities())
        {

            _entities.Configuration.LazyLoadingEnabled = true;
        }
    }
        
        

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}