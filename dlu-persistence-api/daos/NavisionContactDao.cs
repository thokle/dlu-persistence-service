using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class NavisionContactDao

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



        public NavContact GetNavisinForbyContactId(string contact)
        {
          var res =  _entities.Database.SqlQuery<NavContact>("SELECT   dbo.NavisionContact.Name AS BureauNavn, dbo.NavisionContact.Address, dbo.NavisionContact.[Post Code] AS PostNr, dbo.NavisionContact.City AS PostBy, dbo.NavisionContact.[Phone No_] AS TlfNr, dbo.NavisionContact.[VAT Registration No_] AS CVR, " +
                "dbo.NavisionContact.Infogodtgørelse, dbo.NavisionContact.Sikkerhedsgodtgørelse, dbo.NavisionContact.No_  FROM dbo.NavisionContact where dbo.NavisionContact.Name = @contact", new SqlParameter("contact", contact));

            return res.ToList().FirstOrDefault();
        
        }
       
    }

    
}