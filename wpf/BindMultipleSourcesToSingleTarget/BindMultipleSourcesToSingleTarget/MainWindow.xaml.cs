using System.Windows;
using System.ComponentModel;

namespace BindMultipleSourcesToSingleTarget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private string _firstName = "";
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));     
            }
        }

        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
                OnPropertyChanged(nameof(MiddleName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {MiddleName} {LastName}"; }
        }

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Person();
        }
    }
}
