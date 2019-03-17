using GeoLibContracts;
using GeoLibRespositories;

namespace GeoLibServices
{
    public class StatefullGeoManager : IStatefullGeoService
    {
        private ZipCode _zipCodeEntity;

        public ZipCodeData GetZipInfo()
        {
            ZipCodeData zipCodeData = null;
            if (_zipCodeEntity != null)
            {
                zipCodeData = new ZipCodeData()
                {
                    City = _zipCodeEntity.City,
                    State = _zipCodeEntity.State,
                    Zip = _zipCodeEntity.Zip
                };
            }
            return zipCodeData;
        }

        public void PushZip(string zip)
        {

            IZipCodeRepository zipCodeRepository = new ZipCodeRepository();
            _zipCodeEntity = zipCodeRepository.GetZipInfo(zip);
        }
    }
}
