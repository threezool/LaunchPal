using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LaunchPal.API
{
    internal static class HttpCaller
    {
        internal static async Task<T> FetchData<T>(string uri) where T : class 
        {
            using (var client = new HttpClient())
            {
                var result = default(T);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.103 Safari/537.36");

                var response = client.GetAsync(uri).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(content);
                }
                
                return result;
            }
        }
    }
}
