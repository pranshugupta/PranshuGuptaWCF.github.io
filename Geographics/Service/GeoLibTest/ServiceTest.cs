using GeoLibContracts;
using GeoLibServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace GeoLibTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void Test_Zip_Code_Retrivel()
        {
            string address = "net.pipe://localhost/GeoService";
            Binding binding = new NetNamedPipeBinding();

            ServiceHost host = new ServiceHost(typeof(GeoManager));
            host.AddServiceEndpoint(typeof(IGeoService), binding, address);
            host.Open();

            ChannelFactory<IGeoService> factory = new ChannelFactory<IGeoService>(binding, address);

            IGeoService proxy = factory.CreateChannel();

            ZipCodeData zip = proxy.GetZipInfo("12345");
            factory.Close();
            host.Close();

            Assert.IsTrue(zip.Zip == "12345");
        }
    }
}
