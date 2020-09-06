using Map_Service_Api.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Map_Service_Api.services
{
    public class GetMapInfo
    {
        private HttpClient http;

        public GetMapInfo()
        {

            http = new HttpClient();
          
        }


        public async Task<PostNr> GetPostDataForPostNrAsync(int postnr)
        {
           try
            {
                //specify to use TLS 1.2 as default connection
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var client = new HttpClient();

                var content = await client.GetStringAsync("https://dawa.aws.dk/postnumre/" + postnr);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                return await Task.FromResult(JsonConvert.DeserializeObject<PostNr>(content));
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
