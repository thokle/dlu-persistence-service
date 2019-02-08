using System;

namespace dlu_persistence_api.daos
{
    public class OrdreNavisionDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}