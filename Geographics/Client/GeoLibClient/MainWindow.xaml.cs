using GeoLibContracts;
using GeoLibProxies;
using GeoLibProxies.Contract;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Windows;

namespace GeoLibClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "UI running onn thread " + Thread.CurrentThread.ManagedThreadId + " |Process " + Process.GetCurrentProcess().Id.ToString();
            GetZipInfo("12345");
        }

        private void GetZipInfo(string zip)
        {
            GeoClient proxy = new GeoClient("httpE");

            ZipCodeData data = proxy.GetZipInfo(zip);


            // wcf has limited no of connection pipe so we must close it.
            proxy.Close();
        }

        private void GetZipCodes(string state)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:4200/GeoService");
            Binding binding = new BasicHttpBinding();

            GeoClient proxy = new GeoClient(binding, address);

            IEnumerable<ZipCodeData> data = proxy.GetZips("State");
            proxy.Close();
        }

        private void CallMessageService()
        {
            EndpointAddress address = new EndpointAddress("http://localhost:4200/MessageService");
            Binding binding = new BasicHttpBinding();


            ChannelFactory<IMessageService> messageChannelFactory;

            // messageChannelFactory = new ChannelFactory<IMessageService>(""); for unnamed endpoint

            messageChannelFactory = new ChannelFactory<IMessageService>(binding, address);

            IMessageService proxy = messageChannelFactory.CreateChannel();
            proxy.ShowMsg("Proxy by channel");

            messageChannelFactory.Close();
        }

        private void TestExtensibleData()
        {
            GeoClient proxy = new GeoClient("webEp");

            ZipCodeData data = proxy.GetZipInfo("12345");


            // wcf has limited no of connection pipe so we must close it.
            proxy.Close();
        }
    }
}