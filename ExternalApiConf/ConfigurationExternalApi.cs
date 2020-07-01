using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.ExternalApiConf
{
    public class ConfigurationExternalApi : IConfigurationExternalApi
    {
        public string BaseUrl(string EndPoint)
        {
            return $"{this.ExternalUrlApi()}{this.CurrentExternalUrlApiVersion()}{EndPoint}";
        }

        public string CurrentExternalUrlApiVersion()
        {
            return "/v0/";
        }

        public string ExternalUrlApi()
        {
            return "https://hacker-news.firebaseio.com";
        }
    }
}
