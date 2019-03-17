using GeoLibServices;
using System;
using System.ServiceModel;

namespace ConsoleHosting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost hostGeoManager = new ServiceHost(typeof(GeoManager));

            ServiceHost hostStatefullGeoManager = new ServiceHost(typeof(StatefullGeoManager));

            #region
            // you can also provide endpoints from here just comment the service config in app.config.
            // Same can be done in CustomHosting
            /*
            string address = "net.tcp://localhost:4200/GeoService";
            Binding binding = new NetTcpBinding();
            Type contract = typeof(IGeoService);
            hostGeoManager.AddServiceEndpoint(contract, binding, address);
            */
            #endregion

            hostStatefullGeoManager.Open();
            hostGeoManager.Open(); // It requires endpoint configurations
            Console.WriteLine("Service started, Press [Enter] to exit");
            Console.ReadKey();

            hostStatefullGeoManager.Close();
            hostGeoManager.Close();
        }
    }
}
