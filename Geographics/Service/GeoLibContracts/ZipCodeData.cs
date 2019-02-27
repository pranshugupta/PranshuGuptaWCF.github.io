using System.Runtime.Serialization;

namespace GeoLibContracts
{
    [DataContract]
    public class ZipCodeData : IExtensibleDataObject
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}
