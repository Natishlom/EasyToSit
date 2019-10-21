using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyToSit.NexmoDotnetCodeSnippets.Authentication
{
    class BasicAuth
    {
        /// <summary>
        /// Static method to create the client, replace constants with actual        
        /// </summary>
        /// <returns></returns>
        public static Client GetClient()
        {
            const string API_KEY = "9ccfa373";
            const string API_SECRET = "pxqeg16Ou6dNMO2P";

            var client = new Client(creds: new Nexmo.Api.Request.Credentials(
                nexmoApiKey: API_KEY, nexmoApiSecret: API_SECRET));
            return client;
        }
    }
}

