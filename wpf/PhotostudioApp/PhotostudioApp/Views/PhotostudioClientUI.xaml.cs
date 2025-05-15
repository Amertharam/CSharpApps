using Microsoft.Win32;
using System.IO;
using System.Windows;
using PhotostudioApp.ViewModels;
using System;

namespace PhotostudioApp.Views
{
    /// <summary>
    /// Interaction logic for PhotostudioClientUI.xaml
    /// </summary>
    public partial class PhotostudioClientUI : Window
    {
        private readonly ClientVM _viewModel;
        public PhotostudioClientUI()
        {
            InitializeComponent();
            _viewModel = new ClientVM();
            DataContext = _viewModel;
        }
        //private void OnAddImageClick(object sender, RoutedEventArgs e)
        //{
        //    var openFileDialog = new OpenFileDialog();
        //    if (openFileDialog.ShowDialog() == true)
        //    {
        //        var imageBytes = File.ReadAllBytes(openFileDialog.FileName);
        //        _viewModel.AddImage(CustomerIdTextBox.Text, CustomerNameTextBox.Text, ImageTypeTextBox.Text, imageBytes);
        //    }
        //}
        //private void OnFilterClick(object sender, RoutedEventArgs e)
        //{
        //    string customerId = FilterCustomerIdTextBox.Text;
        //    string imageType = FilterImageTypeTextBox.Text;

        //    DateTime? startTime = StartDatePicker.SelectedDate;
        //    DateTime? endTime = EndDatePicker.SelectedDate;

        //    _viewModel.FilterImages(customerId, imageType, startTime, endTime);
        //}
    }
}

