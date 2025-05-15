using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PhotostudioApp.Models
{
    public class Server
    {
        private readonly string storageDirectory;

        public Server(string directory)
        {
            storageDirectory = directory;
            Directory.CreateDirectory(storageDirectory);
        }

        // Store API
        public void StoreImage(ImageData imageData, byte[] imageBytes)
        {
            string fileName = $"{imageData.CustomerId}_{Guid.NewGuid()}_{imageData.ImageType}";
            string filePath = Path.Combine(storageDirectory, fileName);
            File.WriteAllBytes(filePath, imageBytes);

            imageData.FilePath = filePath;
            SaveMetadata(imageData);
        }

        // Retrieve API with filtering
        public List<ImageData> RetrieveImages(Func<ImageData, bool> filter)
        {
            var metadataList = LoadMetadata();
            return metadataList.Where(filter).ToList();
        }

        // Save Metadata
        private void SaveMetadata(ImageData imageData)
        {
            string metadataPath = Path.Combine(storageDirectory, "metadata.txt");
            string metadataLine = $"{imageData.CustomerId.ToString()}|{imageData.CustomerName}|{imageData.ImageType}|{imageData.CreatedTime}|{imageData.FilePath}";
            File.AppendAllLines(metadataPath,  new[] { metadataLine });
        }

        // Load Metadata
        private List<ImageData> LoadMetadata()
        {
            string metadataPath = Path.Combine(storageDirectory, "metadata.txt");
            if (!File.Exists(metadataPath)) return new List<ImageData>();

            return File.ReadAllLines(metadataPath)
                       .Select(line =>
                       {
                           var parts = line.Split('|');
                           return new ImageData
                           {
                               CustomerId = (int)Convert.ToInt32(parts[0]),
                               CustomerName = parts[1],
                               ImageType = parts[2],
                               CreatedTime = DateTime.Parse(parts[3]),
                               FilePath = parts[4]
                           };
                       }).ToList();
        }
    }
}
