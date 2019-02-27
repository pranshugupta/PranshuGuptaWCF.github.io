using System.ServiceModel;

namespace WindowsHosting.Contract
{
    /* either do this or ContractNamespace mapping in assembly.cs
    [ServiceContract(Namespace = "Message_Service_Namespace")]
    */
    [ServiceContract()]
    public interface IMessageService
    {
        [OperationContract]
        void ShowMessage(string message);
    }
}
