using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GameGuild_Android_Client.API
{
    public class GG_Authorization_API
    {
        public static async Task<string> Authorization(string login, string password)
        {
            string auth = String.Empty;
            string fullpath = Settings.Path + "account/token/" + login + "/" + password;

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(fullpath);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return "Not Authorization";
                }
            }
        }
    }
}