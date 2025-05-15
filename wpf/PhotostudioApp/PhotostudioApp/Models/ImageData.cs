using System;

namespace PhotostudioApp.Models
{
    public class ImageData
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ImageType { get; set; } // e.g., "jpeg", "png"
        public DateTime CreatedTime { get; set; }
        public string FilePath { get; set; }
    }
}
