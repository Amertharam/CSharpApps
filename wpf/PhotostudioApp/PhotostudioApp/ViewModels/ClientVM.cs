using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using PhotostudioApp.Commands;
using PhotostudioApp.Models;

namespace PhotostudioApp.ViewModels
{
    public class ClientVM : VMBase
    {
        private readonly Server _server;
        public ICommand AddImageCommand { get; }
        public ICommand FilterImagesCommand { get; }
        public ImageData ImageData { get; set; } = new ImageData();
        public int ID { get { return ImageData.CustomerId; } set { ImageData.CustomerId = value; OnPropertyChanged(nameof(ID)); } }
        public string Name { get { return ImageData.CustomerName; } set { ImageData.CustomerName = value; OnPropertyChanged(nameof(Name)); } }
        public string ImageType { get { return ImageData.ImageType; } set { ImageData.ImageType = value; OnPropertyChanged(nameof(ImageType)); } }
        public int FilterID { get { return ImageData.CustomerId; } set { ImageData.CustomerId = value; OnPropertyChanged(nameof(FilterID)); } }
        public string FilterImageType { get { return ImageData.ImageType; } set { ImageData.ImageType = value; OnPropertyChanged(nameof(FilterImageType)); } }

        private DateTimeConverter _filterFromDate;
        public DateTimeConverter FilterFromDate { get { return _filterFromDate; } set { _filterFromDate = value; OnPropertyChanged(nameof(FilterFromDate)); } }

        private DateTimeConverter _filterToDate;
        public DateTimeConverter FilterToDate { get { return _filterToDate; } set { _filterToDate = value; OnPropertyChanged(nameof(FilterToDate)); } }


        public ObservableCollection<ImageData> Images { get; }

        public ClientVM()
        {
            _server = new PhotostudioApp.Models.Server(@"C:\ImageStorage");
            Images = new ObservableCollection<ImageData>();

            AddImageCommand = new RelayCommand(AddImage, (AddImage) =>true);
            FilterImagesCommand = new RelayCommand(FilterImages, (FilterImages) =>true);
        }
        //private bool CanAddImage(object arg)
        //{
        //    return true;
        //}
        //private bool CanFilterImages(object arg)
        //{
        //    return true;
        //}
        public void AddImage(object parameter)
        {
            object[] obj = parameter as object[];
            ImageData p = new ImageData();
            p.CustomerId = (int)obj[0];
            p.CustomerName = obj[1] as string;
            p.ImageType = obj[2] as string;
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                AddImage(p.CustomerId, p.CustomerName, p.ImageType, imageBytes);
            }
        }
        public void AddImage(int customerId, string customerName, string imageType, byte[] imageBytes)
        {
            var imageData = new ImageData
            {
                CustomerId = customerId,
                CustomerName = customerName,
                ImageType = imageType,
                CreatedTime = DateTime.Now
            };

            _server.StoreImage(imageData, imageBytes);
            Images.Add(imageData);
        }
        public void FilterImages(object parameter)
        {
            object[] obj = parameter as object[];
            ImageData p = new ImageData();
            p.CustomerId = (int)obj[0];
            p.ImageType = obj[1] as string;
            DateTime startTime = Convert.ToDateTime(obj[2]);
            DateTime endTime = Convert.ToDateTime(obj[3]);
            FilterImages(p.CustomerId, p.ImageType, startTime, endTime);
        }
        public void FilterImages(int customerId, string imageType = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            Images.Clear();
            var filteredImages = _server.RetrieveImages(image =>
                (image.CustomerId == customerId) &&
                (string.IsNullOrEmpty(imageType) || image.ImageType == imageType) &&
                (!startTime.HasValue || image.CreatedTime >= startTime) &&
                (!endTime.HasValue || image.CreatedTime <= endTime));

            foreach (var image in filteredImages)
            {
                Images.Add(image);
            }
        }
    }
}
