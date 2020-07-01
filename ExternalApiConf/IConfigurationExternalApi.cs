using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.ExternalApiConf
{
    interface IConfigurationExternalApi
    {
        string BaseUrl(string EndPoint);
        string ExternalUrlApi();
        string CurrentExternalUrlApiVersion();
    }
}
