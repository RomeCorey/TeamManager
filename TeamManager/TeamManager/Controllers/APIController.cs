using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TeamManager.Models;

namespace TeamManager.Controllers
{
    static class APIController 
    {
        // GET: API
        public static LatLong GoogleCall(string address)
        {
            var split = address.Split(' ');
            var joinAddress = String.Join("+",split);
            LatLong latlong = new LatLong();
            var client = new RestClient("https://maps.googleapis.com/maps/api/geocode/json?address="+joinAddress+"&key=AIzaSyBgy517PxiQ5LcN82qIqrkfJxErCOSJ2Gc");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "ba22312c-8463-76ef-1051-9947d743011d");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            var responseData = JsonConvert.DeserializeObject<apiCalls>(response.Content);
            var lat = responseData.Results[0].Geometry.Location.Lat.ToString();
            var longitude = responseData.Results[0].Geometry.Location.Lng.ToString();
            latlong.lat = lat;
            latlong.lng = longitude;
            return latlong;
        }
    }
}