﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api
{
    public class UpdateBladDaekning
    {
        private DiMPdotNetDevEntities entities;

        public UpdateBladDaekning()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public string importCSV()
        {
            List<int> resultats = new List<int>();
            using (var read = new StreamReader("C:/Users/Thomas Kleist/Documents/UpdateBladDaekningPrStamBladv2.csv"))
            {
                List<tblBladDækning> dæknings = new List<tblBladDækning>();
                string currentLine;

                while ((currentLine = read.ReadLine()) != null)
                {
                    List<string> line = currentLine.Split(',').ToList();
                    tblBladDækning dækning = new tblBladDækning();
                    if (int.TryParse(line[0], out int i))
                    {
                        dækning.BladID = i;
                    }

                    if (int.TryParse(line[1], out int j))
                    {
                        dækning.PostNr = j;
                    }

                    if (int.TryParse(line[2], out int k))
                    {
                        dækning.Oplag = k;
                    }

                    if (int.TryParse(line[3], out int l))
                    {
                        dækning.DækningsGrad = l;
                    }


                    var res = update(dækning);
                    resultats.Add(res.Result);
                }



            }


            return JsonConvert.SerializeObject(resultats, Formatting.Indented);

        }

        private Task<int> update(tblBladDækning dækning)
        {
            entities.tblBladDækning.AddOrUpdate(dækning);
            return entities.SaveChangesAsync();
        }

    }
}

