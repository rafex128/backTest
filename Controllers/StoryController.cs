using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTest.ExternalApiConf;
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
        public int[] Get()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(ApiUrl.BaseUrl("beststories.json"));
            RestRequest request = new RestRequest();
            request.Method = Method.GET;

            IRestResponse retorno = client.Execute(request);
            return JsonConvert.DeserializeObject<int[]>(retorno.Content);
        }
    }
}
