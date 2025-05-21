using System;
using System.Windows;
using System.IO;
using System.IO.Ports;
using EasyModbus;
using System.Security.RightsManagement;

namespace ModbusTCP_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool bit1;
        private bool bit2;
        ModbusClient modbusTcpClient; 
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            modbusTcpClient = new ModbusClient();
            modbusTcpClient.IPAddress = "127.0.0.1";
            modbusTcpClient.Port = 502;
            if (!modbusTcpClient.Connected)
            {
                try
                {
                    modbusTcpClient.Connect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Comm. Error + {ex.Message}");
                }
            }
        }

        private void RegRead_Button_Click(object sender, RoutedEventArgs e)
        {
            var reg = modbusTcpClient.ReadInputRegisters(1, 2);
            txtboxReadReg1.Text = Convert.ToInt32(reg[0]).ToString();
            txtboxReadReg2.Text = Convert.ToInt32(reg[1]).ToString();
        }
        private void RegWrite_Button_Click(object sender, RoutedEventArgs e)
        {
            modbusTcpClient.WriteSingleRegister(1, Convert.ToUInt16(txtboxWriteReg1.Text));
            modbusTcpClient.WriteSingleRegister(2, Convert.ToUInt16(txtboxWriteReg2.Text));
        }
        private void chkbxBit1_Checked(object sender, RoutedEventArgs e)
        {
            bit1 = true;
            txtbxBit1.Text = Convert.ToString(bit1);
            modbusTcpClient.WriteSingleCoil(0, bit1);
        }
        private void chkbxBit2_Checked(object sender, RoutedEventArgs e)
        {
            bit2 = true;
            txtbxBit2.Text = Convert.ToString(bit2);
            modbusTcpClient.WriteSingleCoil(1, bit2);
        }
        private void chkbxBit1_Unchecked(object sender, RoutedEventArgs e)
        {
            bit1 = false;
            txtbxBit1.Text = Convert.ToString(bit1);
            modbusTcpClient.WriteSingleCoil(0, bit1);
        }
        private void chkbxBit2_Unchecked(object sender, RoutedEventArgs e)
        {
            bit2 = false;
            txtbxBit2.Text = Convert.ToString(bit2);
            modbusTcpClient.WriteSingleCoil(1, bit2);
        }
    }
}