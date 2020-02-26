using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class NavisionContactDao : IDisposable

    {
        private DiMPdotNetDevEntities _entities;

        public NavisionContactDao()
        {
            _entities = new DiMPdotNetDevEntities();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salesPersonId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetNavisionContactbySalesPersonId(string salesPersonId)
        {
            try
            {
                var res = from nc in _entities.NavisionContacts
                          where nc.Salesperson_Code == salesPersonId
                          orderby nc.Salesperson_Code
                          select new
                          {
                              nc.Name,
                              nc.Address,
                              nc.City,
                              nc.Deaktiveret,
                              nc.Infogodtgørelse,
                              nc.No_,
                              nc.Sikkerhedsgodtgørelse,
                              nc.Phone_No_,
                              nc.Salesperson_Code,
                              nc.Post_Code,
                              nc.Bill_to_Contact_No_,
                              nc.ContactNoFilter,
                              nc.EAN_nummer,
                              nc.Invoice_Document_Type,
                              nc.Payment_Terms_Code,
                              nc.VAT_Registration_No_
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