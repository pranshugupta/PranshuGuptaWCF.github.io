using System.ServiceModel;

namespace GeoLibProxies.Contract
{
    // either above name space should be same as Service contract in Windows Hosting or Namespace property should be the same


    /* either do this or ContractNamespace mapping in assembly.cs
    [ServiceContract(Namespace = "Message_Service_Namespace")]
    */
    [ServiceContract()]
    public interface IMessageService
    {
        [OperationContract(Name = "ShowMessage")]
        void ShowMsg(string message);
    }
}
