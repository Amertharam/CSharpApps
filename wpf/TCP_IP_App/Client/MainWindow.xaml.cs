using System.Text;
using System.Windows;
using SuperSimpleTcp;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SimpleTcpClient client;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                client.Connect();

            }
            catch (Exception ex)
            {

                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtbxMessage.Text))
                {
                    client.Send(txtbxMessage.Text);
                    txtbxInfo.Text += $"client : {txtbxMessage.Text}{Environment.NewLine}";
                    txtbxMessage.Text = string.Empty;
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            client = new SimpleTcpClient(txtbxIP.Text);
            client.Events.Connected += Events_ServerConnected;
            client.Events.Disconnected += Events_ServerDisconnected;
            client.Events.DataReceived += Events_DataReceived;
        }
        private void Events_ServerConnected(object? sender, ConnectionEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                txtbxInfo.Text += $"{e.IpPort} server connected {Environment.NewLine}";
            })
            );
        }
        private void Events_ServerDisconnected(object? sender, ConnectionEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                txtbxInfo.Text += $"{e.IpPort} server dis-connected {Environment.NewLine}";
            })
            );
        }
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                txtbxInfo.Text += $"{e.IpPort} server : {Encoding.UTF8.GetString(e.Data)} {Environment.NewLine}";
            })
            );
        }
    }
}