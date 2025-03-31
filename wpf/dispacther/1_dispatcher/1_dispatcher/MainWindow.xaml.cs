using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1_dispatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void updateLabel()
        {
            Task.Delay(2000).Wait();
            //uncomment the below line to see. what happens if you update the UI TextBox without dispatcher
            //txtBx1.Text = "updated text";
            Dispatcher.Invoke(() => { txtBx1.Text = "updated text using dispatcher"; });
        }
        public MainWindow()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(updateLabel));
            thread.Start();            
        }
    }
}
