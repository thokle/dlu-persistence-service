using System;

namespace dlu_persistence_api.daos
{
    public class OrdreGebyrNavisionDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public OrdreGebyrNavisionDao()
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