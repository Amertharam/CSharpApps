using System.Windows;
using NationalInstruments.DAQmx;

namespace NI_USB6008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }  

        private void butReadData_Click(object sender, RoutedEventArgs e)
        {
            getData();
        }
        public void getData()
        {
            NationalInstruments.DAQmx.Task AnalogInChannel = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = AnalogInChannel.AIChannels.CreateVoltageChannel("Dev1/AI0", "myAIChannel", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(AnalogInChannel.Stream);
            double data = reader.ReadSingleSample();
            txtBlock.Text = data.ToString();
        }
    }
}
