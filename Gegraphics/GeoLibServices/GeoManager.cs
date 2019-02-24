using GeoLibContracts;
using GeoLibRespositories;
using System.Collections.Generic;

namespace GeoLibServices
{
    public class GeoManager : IGeoService
    {
        private IZipCodeRepository _zipCodeRepo;
        private IStateRepository _stateRepo;

        public GeoManager()
        {

        }
        public GeoManager(IZipCodeRepository zipCodeRepo)
        {
            _zipCodeRepo = zipCodeRepo;
        }
        public GeoManager(IStateRepository stateRepo)
        {
            _stateRepo = stateRepo;
        }
        public GeoManager(IZipCodeRepository zipCodeRepo, IStateRepository stateRepo)
        {
            _stateRepo = stateRepo;
            _zipCodeRepo = zipCodeRepo;
        }
        public IEnumerable<string> GetStates(bool primaryOnly)
        {
            if (null == _stateRepo)
            {
                _stateRepo = new StateRepository();
            }

            return _stateRepo.GetStates(primaryOnly);
        }

        public ZipCodeData GetZipInfo(string zip)
        {
            if (null == _zipCodeRepo)
            {
                _zipCodeRepo = new ZipCodeRepository();
            }
            ZipCode zipCode = _zipCodeRepo.GetZipInfo(zip);
            ZipCodeData zipCodeData = new ZipCodeData()
            {
                City = zipCode.City,
                State = zipCode.State,
                Zip = zipCode.Zip
            };
            return zipCodeData;
        }

        public IEnumerable<ZipCodeData> GetZips(string state)
        {
            if (null == _zipCodeRepo)
            {
                _zipCodeRepo = new ZipCodeRepository();
            }

            List<ZipCodeData> zipCodeDatas = new List<ZipCodeData>();
            IEnumerable<ZipCode> zipCodes = _zipCodeRepo.GetZips(state);

            foreach (ZipCode zipCode in zipCodes)
            {
                zipCodeDatas.Add(new ZipCodeData()
                {
                    City = zipCode.City,
                    State = zipCode.State,
                    Zip = zipCode.Zip
                });
            }

            return zipCodeDatas;
        }

        public IEnumerable<ZipCodeData> GetZips(string zip, int range)
        {
            if (null == _zipCodeRepo)
            {
                _zipCodeRepo = new ZipCodeRepository();
            }

            List<ZipCodeData> zipCodeDatas = new List<ZipCodeData>();
            IEnumerable<ZipCode> zipCodes = _zipCodeRepo.GetZips(zip, range);

            foreach (ZipCode zipCode in zipCodes)
            {
                zipCodeDatas.Add(new ZipCodeData()
                {
                    City = zipCode.City,
                    State = zipCode.State,
                    Zip = zipCode.Zip
                });
            }

            return zipCodeDatas;
        }
    }
}
