using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace Map_Service_Api.services
{
    public class JsonService
    {
      Newtonsoft.Json.JsonSerializer serializer { get; set; }
        public JsonService()
        {
            serializer = new JsonSerializer();
        }

        public Feature GetResponseByZipCode(string zipCode)
        {
            try
            {
                // read JSON directly from a file
                using (StreamReader file = System.IO.File.OpenText(@"jsons/postnumre.json"))
                {

                    Root root = (Root)serializer.Deserialize(file, typeof(Root));
                   return root.features.Find(e => e.properties.POSTNR_TXT.Equals(zipCode));
                }
            }
            catch 
                (Exception ex)
            {
                throw new Exception(ex.HelpLink, ex.InnerException);
            }
        }
    }
}
