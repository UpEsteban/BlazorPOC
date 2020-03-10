using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TuringTest.Models;

namespace TuringTest.Services
{
    public class TextUtilitiesService
    {
        readonly HttpClient client = new HttpClient();
        readonly string value = "http://localhost:7071/api/TextUtilities";

        public async Task<TextUtility> GetAsync(string Text)
        {
            HttpResponseMessage response = await client.GetAsync($"{value}?Texts={Text}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TextUtility>(responseBody); ;
        }
    }
}
