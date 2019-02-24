using System.Runtime.Serialization;

namespace GeoLibContracts
{
    [DataContract]
    public class ZipCodeData
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

    }
}
