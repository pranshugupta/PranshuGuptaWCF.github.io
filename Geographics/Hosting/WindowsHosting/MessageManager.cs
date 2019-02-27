using System.ServiceModel;
using WindowsHosting.Contract;

namespace WindowsHosting.Service
{
    [ServiceBehavior(UseSynchronizationContext = false)] // this will make service execute in background thread
    public class MessageManager : IMessageService
    {
        public void ShowMessage(string message)
        {
            MainWindow.MainUI.ShowMessage(message);
        }
    }
}
