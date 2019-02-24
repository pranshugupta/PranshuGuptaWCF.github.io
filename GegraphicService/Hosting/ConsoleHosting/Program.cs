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
            hostGeoManager.Open(); // It requires endpoint configurations
            Console.WriteLine("Service started, Press [Enter] to exit");
            Console.ReadKey();

            hostGeoManager.Close();
        }
    }
}
