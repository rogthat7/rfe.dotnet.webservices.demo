using rfe.dotnet.webservices.ihelloremotingservice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace rfe.dotnet.webservices.helloremotingserviceclient
{
    public partial class Form1 : Form
    {
        IHelloRemotingService client; 
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingService)Activator.GetObject(
                typeof(IHelloRemotingService), "tcp://localhost:8080/GetMessage" // GetMessage is the Unique Identifier RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService),"GetMessage",WellKnownObjectMode.Singleton);
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = client.GetMessage(textBox1.Text);
        }
    }
}
