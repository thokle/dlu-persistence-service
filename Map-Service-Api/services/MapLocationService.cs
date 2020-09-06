using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Map_Service_Api.services
{
    public class MapLocationService
    {
        private GetMapInfo mapInfo  = null;

        public MapLocationService()
        {
            mapInfo = new GetMapInfo();
        }
        public async Task<List<MapPolygon>> CreateMapFromMediePlan(List<int> postnr) {
            try {
                List<MapPolygon> maps = new List<MapPolygon>();
                postnr.ForEach(p =>
                {
                    var res = mapInfo.GetPostDataForPostNrAsync(p).Result;
                    var collection = new LocationCollection();

                    collection.Add(new Location(res.bbox[0], res.bbox[1]));
                    collection.Add(new Location(res.bbox[0], res.bbox[1]));
                    var polygon = new MapPolygon();
                    polygon.Locations = collection;
                    maps.Add(polygon);
                });
                return await Task.FromResult(maps);
            } catch(Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }            

}

