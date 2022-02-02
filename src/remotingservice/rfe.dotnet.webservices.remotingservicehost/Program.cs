using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using rfe.dotnet.webservices.helloremotingservice;

namespace rfe.dotnet.webservices.remotingservicehost
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloRemotingService remotingService = new HelloRemotingService();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService), 
                "GetMessage",
                WellKnownObjectMode.Singleton);
            Console.WriteLine($"Remoting Service Started @ {DateTime.Now}");
            Console.ReadLine();
        }
    }
}
