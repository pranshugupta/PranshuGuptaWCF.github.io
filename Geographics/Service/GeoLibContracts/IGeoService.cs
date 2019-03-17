using System.Collections.Generic;
using System.ServiceModel;

namespace GeoLibContracts
{
    [ServiceContract(CallbackContract = typeof(IUpdateCallback))]
    public interface IGeoService
    {
        [OperationContract]
        ZipCodeData GetZipInfo(string zip);

        [OperationContract]
        IEnumerable<string> GetStates(bool primaryOnly);

        [OperationContract(Name = "GetZipByState")]
        IEnumerable<ZipCodeData> GetZips(string state);


        [OperationContract(Name = "GetZipForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);

        [OperationContract()]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateZip(string zip, string city);

        [OperationContract(IsOneWay = true)]
        void OneWayExample();
    }

    [ServiceContract]
    public interface IUpdateCallback
    {
        [OperationContract(IsOneWay = true)]
        void updated(string s);
    }
}
