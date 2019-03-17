using GeoLibContracts;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace GeoLibProxies
{
    public class StatefullGeoClient : ClientBase<IStatefullGeoService>, IStatefullGeoService
    {

        // if there is only one endpoint then there is no need to give constructor
        public StatefullGeoClient(string endpointName) : base(endpointName)
        {

        }

        public StatefullGeoClient(Binding binding, EndpointAddress address) : base(binding, address)
        {

        }

        public ZipCodeData GetZipInfo()
        {
            return Channel.GetZipInfo();
        }

        public void PushZip(string zip)
        {
            Channel.PushZip(zip);
        }
    }
}
