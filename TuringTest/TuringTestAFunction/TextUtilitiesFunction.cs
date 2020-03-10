using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TuringTestAFunction.Model;
using System.Collections.Generic;

namespace TuringTestAFunction
{
    public static class TextUtilitiesController
    {
        [FunctionName("TextUtilities")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string texts = req.Query["Texts"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            texts = texts ?? data?.name;

            TextUtility textUtilityDTO = new TextUtility();

            textUtilityDTO.DetectedLanguage = "ESPAÑOL";
            textUtilityDTO.Entities = new List<string> { "cacatua", "segunda" };
            textUtilityDTO.Intents = new List<string> { "intent1", "intent1" };
            textUtilityDTO.KeyWord = "keyword";
            textUtilityDTO.SentimentalRate = 0.8F;
            textUtilityDTO.TranslateLanguage = texts;

            var json = JsonConvert.SerializeObject(textUtilityDTO);

            return new OkObjectResult(json);
        }
    }
}
