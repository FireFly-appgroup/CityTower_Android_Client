using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CityTower_Android_Client.Models;
using Newtonsoft.Json;

namespace GameGuild_Android_Client.API
{
    public class GG_News_API
    {
        public static async Task<string> GetMiniNews()
        {
            string fullpath = Settings.Path + "news/getall";
            try
            {
                using (var client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage();
                    request.RequestUri = new Uri(fullpath);
                    request.Method = HttpMethod.Get;
                    request.Headers.Add("Accept", "application/json");

                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        HttpContent responseContent = response.Content;
                        var json = await responseContent.ReadAsStringAsync();
                        //var mininews = JsonConvert.DeserializeObject<List<gg_news_mini>>(json);
                        //dynamic dyn = JsonConvert.DeserializeObject(res);
                        //Friends facebookFriends = new JavaScriptSerializer().Deserialize<gg_news_mini>(mininews);
                        return await responseContent.ReadAsStringAsync();
                    }
                    else
                    {
                        return "Not Authorization";
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}