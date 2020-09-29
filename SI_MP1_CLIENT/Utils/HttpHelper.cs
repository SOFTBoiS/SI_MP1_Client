using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using SoftSearchImages.Models;

namespace SoftSearchImages
{
    public class HttpHelper
    {
        private static HttpClient _client = new HttpClient();

        public async Task<string> PostRequest(string url, Dictionary<string, string> values)
        {
            System.Diagnostics.Debug.WriteLine("Post request");
            var content = "{\"UserName\": \"" + values["UserName"] + "\", \"URL\":\"" + values["URL"] + "\"}";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
                var responseBody = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseBody);
                return responseBody;
            }

        }
        public static async Task<string> GetRequest(string url, string queryParameter)
        {
            Debug.WriteLine(queryParameter);
            var response = await _client.GetAsync(url + "?username=" + queryParameter);

            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }



        public string SaveSearch(string searchValue)
        {
            var name = SearchModel.SavedName;
            var values = new Dictionary<string, string>();
            values.Add("UserName", name);
            values.Add("URL", searchValue);

            var res = Task.Run(async () => await PostRequest("https://localhost:44310/api/Images", values));
            return res.Result;
        }

        public static string GetSearchHistory()
        {
            var name = SearchModel.SavedName;
            Debug.WriteLine("Before");
            var res = Task.Run(async () => await GetRequest("https://localhost:44310/api/Images", name));

            return res.Result;
        }



    }
}
