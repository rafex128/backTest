using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.ExternalApiConf
{
    public class ConfigurationExternalApi : IConfigurationExternalApi
    {
        public string BaseUrl()
        {
            return $"{this.ExternalUrlApi()}{this.CurrentExternalUrlApiVersion()}";
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
