using System;
using System.ServiceModel;
using System.Threading;
using System.Windows;
using WindowsHosting.Contract;
using WindowsHosting.Service;

namespace WindowsHosting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceHost geoManagerHost = null;
        private ServiceHost messageManagerHost = null;
        public static MainWindow MainUI { get; set; }

        private SynchronizationContext syncContext = SynchronizationContext.Current;
        public MainWindow()
        {
            InitializeComponent();

            Title = "UI running on thread" + Thread.CurrentThread.ManagedThreadId;

            MainUI = this;
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            // geoManagerHost = new ServiceHost(typeof(GeoManager));
            messageManagerHost = new ServiceHost(typeof(MessageManager));


            // geoManagerHost.Open();
            messageManagerHost.Open();
            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
        }

        private void Stop(object sender, RoutedEventArgs e)
        {

            // geoManagerHost.Close();
            // messageManagerHost.Close();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

        }

        public void ShowMessage(string message)
        {
            SendOrPostCallback callback = new SendOrPostCallback(args =>
            InProcTextBlock.Text = message + Environment.NewLine + "Thread:" + Thread.CurrentThread.ManagedThreadId
                );
            syncContext.Send(callback, null);
        }

        private void InProcStart(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(() =>
            {
                ChannelFactory<IMessageService> factory = new ChannelFactory<IMessageService>("netPipeE");

                factory.CreateChannel().ShowMessage(DateTime.Now.ToLongTimeString());
                factory.Close();
            })
            {
                IsBackground = true
            };
            t.Start();
        }
    }
}
