using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BackendTest.ExternalApiConf;
using BackendTest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private ConfigurationExternalApi ApiUrl = new ConfigurationExternalApi();
        // GET: api/<StoryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(ApiUrl.BaseUrl("beststories.json"));
            RestRequest request = new RestRequest();
            request.Method = Method.GET;

            IRestResponse retorno = client.Execute(request);

            try
            {
                List<StoryResult> stories = new List<StoryResult>();
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

                if (retorno.StatusCode == HttpStatusCode.OK)
                {
                    //Get 20 firsts best stories
                    IEnumerable<int> bstStoris = JsonConvert.DeserializeObject<int[]>(retorno.Content).Take(20);

                    foreach (int storyId in bstStoris)
                    {
                        client.BaseUrl = new Uri(ApiUrl.BaseUrl($"item/{storyId}.json"));
                        request = new RestRequest();
                        request.Method = Method.GET;

                        retorno = client.Execute(request);

                        Story story = JsonConvert.DeserializeObject<Story>(retorno.Content);

                        //Convert to StoryResult
                        stories.Add(new StoryResult(story.Title, story.Url, story.By, start.AddSeconds(story.Time).ToLocalTime().ToString(), story.Score, story.Kids.Count()));
                    }
                }

                return Ok(stories);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}