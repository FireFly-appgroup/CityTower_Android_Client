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
        public static async Task<List<gg_news_mini>> GetMiniNews()
        {
            string fullpath = Settings.Path + "news/getall";
            try
            {
                using (var client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage() { RequestUri = new Uri(fullpath), Method = HttpMethod.Get };
                    request.Headers.Add("Accept", "application/json");
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        //var mininews = JsonConvert.DeserializeObject<List<gg_news_mini>>(await response.Content.ReadAsStringAsync());
                        return JsonConvert.DeserializeObject<List<gg_news_mini>>(await response.Content.ReadAsStringAsync(), new JsonSerializerSettings
                        {
                           // Formatting = Formatting.Indented,
                            NullValueHandling = NullValueHandling.Ignore
                        });
                    }
                    else
                    {
                        return null;
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