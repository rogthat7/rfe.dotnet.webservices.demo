using rfe.dotnet.webservices.ihelloremotingservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rfe.dotnet.webservices.helloremotingservice
{
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService
    {
        public string GetMessage(string name)
        {
            return $"Hello {name}";
        }
    }
}
