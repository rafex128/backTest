using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTest.ExternalApiConf;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<string> Get()
        {
            return new string[] { ApiUrl.BaseUrl(), "value2" };
        }
    }
}
