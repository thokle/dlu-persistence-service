using System;
using System.Linq;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class NavisionContactDao: IDisposable

    {
    private DiMPdotNetEntities _entities;

    public NavisionContactDao()
    {
        using (_entities = new DiMPdotNetEntities())
        {
            _entities.Configuration.LazyLoadingEnabled = true;
        }
    }

        public string GetNavisionContactbySalesPersonId(string salesPersonId)
        {
            try
            {
                var res = from nc in _entities.NavisionContacts
                    where nc.Salesperson_Code == salesPersonId
                    orderby nc.Salesperson_Code
                    select new
                    {
                        nc.Name, nc.Address, nc.City, nc.Deaktiveret, nc.Infogodtgørelse, nc.No_, nc.Sikkerhedsgodtgørelse, nc.Phone_No_, nc.Salesperson_Code,
                        nc.Post_Code, nc.Bill_to_Contact_No_ , nc.ContactNoFilter, nc.EAN_nummer, nc.Invoice_Document_Type, nc.Payment_Terms_Code, nc.VAT_Registration_No_
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetNavisionContactbySalesPersonId ", e.InnerException);
            }
        }
        
        
        
        
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}