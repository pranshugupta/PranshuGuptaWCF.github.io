using System.Collections.Generic;

namespace GeoLibRespositories
{
    public class ZipCodeRepository : IZipCodeRepository
    {
        public ZipCode GetZipInfo(string zip)
        {
            ZipCode zipCodeData = new ZipCode()
            {
                City = "My City",
                State = "My State",
                Zip = "12345"
            };
            return zipCodeData;
        }

        public IEnumerable<ZipCode> GetZips(string state)
        {
            List<ZipCode> zips = new List<ZipCode>
            {
               new ZipCode()
               {
                City = "My City",
                State = "My State",
                Zip = "12345"
               },
               new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
               new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
                new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
                new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
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
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
               new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
               new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
                new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
                new ZipCode()
                {
                City = "My City",
                State = "My State",
                Zip = "12345"
                },
            };

            return zips;
        }
    }
}
