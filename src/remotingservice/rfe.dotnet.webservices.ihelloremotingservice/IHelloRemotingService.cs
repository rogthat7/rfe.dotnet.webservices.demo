using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rfe.dotnet.webservices.ihelloremotingservice
{
    public interface IHelloRemotingService
    {
        string GetMessage(string name);
    }
}
