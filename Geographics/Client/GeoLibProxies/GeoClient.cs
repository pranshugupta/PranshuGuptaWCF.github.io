using GeoLibContracts;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace GeoLibProxies
{
    public class GeoClient : DuplexClientBase<IGeoService>, IGeoService
    {

        // if there is only one endpoint then there is no need to give constructor
        public GeoClient(InstanceContext context, string endpointName) : base(context, endpointName)
        {

        }

        public GeoClient(InstanceContext context, Binding binding, EndpointAddress address) : base(context, binding, address)
        {

        }

        public IEnumerable<string> GetStates(bool primaryOnly)
        {
            return Channel.GetStates(primaryOnly);
        }

        public ZipCodeData GetZipInfo(string zip)
        {
            return Channel.GetZipInfo(zip);
        }

        public IEnumerable<ZipCodeData> GetZips(string state)
        {
            return Channel.GetZips(state);
        }

        public IEnumerable<ZipCodeData> GetZips(string zip, int range)
        {
            return Channel.GetZips(zip, range);
        }


        public void UpdateZip(string zip, string city)
        {
            Channel.UpdateZip(zip, city);
        }

        public void OneWayExample()
        {
            Channel.OneWayExample();
        }
    }
}
