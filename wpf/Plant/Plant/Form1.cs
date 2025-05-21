using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace Plant
{
    public partial class Form1 : Form
    {
        private StandardServer _server;
        private ApplicationInstance _instance;
        private ApplicationConfiguration _configuration;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(ApplicationInstance appInstance)
        {
            InitializeComponent();
            _instance = appInstance;
            _server = appInstance.Server as StandardServer;
            _configuration = appInstance.ApplicationConfiguration;     
            
            this.comboBox1.Items.Clear();
            foreach (var endpoint in _server.GetEndpoints())
            {
                this.comboBox1.Items.Add(endpoint.EndpointUrl);
            }
            if (this.comboBox1.Items.Count > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }
    }
}
