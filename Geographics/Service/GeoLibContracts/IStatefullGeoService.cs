using System.ServiceModel;

namespace GeoLibContracts
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IStatefullGeoService
    {
        [OperationContract(IsInitiating = true)]
        void PushZip(string zip);

        [OperationContract(IsInitiating = false)]
        ZipCodeData GetZipInfo();
    }
}
