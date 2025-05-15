using SuperSimpleTcp;
using System.Text;
using System.Windows;

namespace Server
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SimpleTcpServer server;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            server.Start();
            txtbxInfo.Text += $"server started listening... at {txtbxIP.Text}{Environment.NewLine}";
            btnStart.IsEnabled = false;
        }
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtbxMessage.Text) && lstbxClientIP.SelectedItem != null)
                {
                    server.Send(lstbxClientIP.SelectedItem.ToString(), txtbxMessage.Text);
                    txtbxInfo.Text += $"server : {txtbxMessage.Text}{Environment.NewLine}";
                    txtbxMessage.Text = string.Empty;
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            server = new SimpleTcpServer(txtbxIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }
        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            Dispatcher.Invoke(new Action( () =>
            {
                txtbxInfo.Text += $"{e.IpPort} client connected {Environment.NewLine}";
                lstbxClientIP.Items.Add(e.IpPort);
            })
            );
        }
        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                txtbxInfo.Text += $"{e.IpPort} client dis-connected {Environment.NewLine}";
                lstbxClientIP.Items.Remove(e.IpPort);
            })
            );
        }
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                txtbxInfo.Text += $"{e.IpPort} client : {Encoding.UTF8.GetString(e.Data)} {Environment.NewLine}";
            })
            );
        }
    }
}