using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class WEBSendTilKollegaDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public WEBSendTilKollegaDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string WEBSendTilKollegaDaoByPersonID(int personId)
        {
            try
            {
                var res = from we in _entities.tblWEBSendTilKollegas
                    where we.PersonID == personId orderby we.PersonID
                    select new
                    {
                        we.BladID, we.eMails,we.PersonID
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("WEBSendTilKollegaDaoByPersonID", e.InnerException);
            }
        }

        public string WEBSendTilKollegaDaoByBladID(int bladId)
        {

            try
            {
                var res = from we in _entities.tblWEBSendTilKollegas
                    where we.BladID == bladId orderby we.PersonID
                    select new
                    {
                        we.BladID, we.eMails,we.PersonID
                    };
                
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            
            }
            catch (Exception e)
            {
                throw new DaoExceptions("WEBSendTilKollegaDaoByBladID", e.InnerException);
            }
        }

        public string WEBSendTilKollegaDaoByeMails(string emails)
        {
            try
            {
                var res = from we in _entities.tblWEBSendTilKollegas
                    where we.eMails == emails orderby we.PersonID
                    select new
                    {
                        we.BladID, we.eMails,we.PersonID
                    };
                
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("WEBSendTilKollegaDaoByeMails", e.InnerException);
            } 
        }

        public Task<int> CreateOrUpdata(tblWEBSendTilKollega tilKollega)
        {
            try
            {
                    _entities.tblWEBSendTilKollegas.AddOrUpdate(tilKollega);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e);
            }   
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}