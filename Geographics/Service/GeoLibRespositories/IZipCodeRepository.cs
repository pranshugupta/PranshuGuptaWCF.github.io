using System.Collections.Generic;

namespace GeoLibRespositories
{
    public interface IZipCodeRepository
    {
        ZipCode GetZipInfo(string zip);
        IEnumerable<ZipCode> GetZips(string state);
        IEnumerable<ZipCode> GetZips(string zip, int range);
        void UpdateZip(string zip, string city);
    }
}
