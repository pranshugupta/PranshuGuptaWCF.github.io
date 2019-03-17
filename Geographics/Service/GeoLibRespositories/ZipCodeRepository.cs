using System.Collections.Generic;

namespace GeoLibRespositories
{
    public class ZipCodeRepository : IZipCodeRepository
    {
        public ZipCode GetZipInfo(string zip)
        {
            ZipCode zipCodeData = new ZipCode()
            {
                City = "My City0",
                State = "My State0",
                Zip = "123450"
            };
            return zipCodeData;
        }

        public IEnumerable<ZipCode> GetZips(string state)
        {
            List<ZipCode> zips = new List<ZipCode>
            {
               new ZipCode()
               {
                City = "My City1",
                State = "My State1",
                Zip = "123451"
               },
               new ZipCode()
                {
                City = "My City2",
                State = "My State2",
                Zip = "123452"
                },
               new ZipCode()
                {
                City = "My City3",
                State = "My State3",
                Zip = "123453"
                },
                new ZipCode()
                {
                City = "My City4",
                State = "My State4",
                Zip = "123454"
                },
                new ZipCode()
                {
                City = "My City5",
                State = "My State5",
                Zip = "123455"
                },
            };

            return zips;
        }

        public IEnumerable<ZipCode> GetZips(string zip, int range)
        {
            List<ZipCode> zips = new List<ZipCode>
            {
               new ZipCode()
                {
                City = "My City1",
                State = "My State1",
                Zip = "123451"
                },
               new ZipCode()
                {
                City = "My City2",
                State = "My State2",
                Zip = "123452"
                },
               new ZipCode()
                {
                City = "My City3",
                State = "My State3",
                Zip = "123453"
                },
                new ZipCode()
                {
                City = "My City4",
                State = "My State4",
                Zip = "123454"
                },
                new ZipCode()
                {
                City = "My City5",
                State = "My State5",
                Zip = "123455"
                },
            };

            return zips;
        }

        public void UpdateZip(string zip, string city)
        {

        }
    }
}
