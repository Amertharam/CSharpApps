using System.Collections.Generic;
using System.Windows;

namespace DataTemplate
{
    public class Class1 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
        public List<string> Skills { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Class1 _class1;

        public Class1 Class1Property
        {
            get { return _class1; }
            set { _class1 = value; }
        }
     
        public MainWindow()
        {
            InitializeComponent();

            List<string> skilList = new List<string>();
            skilList.Add("CSharp");
            skilList.Add("CPlusPlus");
            Class1Property = new Class1() { Name = "ABC", Id = 001, Designation= "Engineer", Skills=skilList };

            DataContext = this;
        }
    }
}
