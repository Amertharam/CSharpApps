using System;
using System.IO;

namespace _1_Dispose
{
    public class ResourceHolder : IDisposable
    {
        // Unmanaged resource
        private IntPtr unmanagedResource;

        // Managed resource
        private IDisposable managedResource;

        public ResourceHolder()
        {
            // Allocate resources
            unmanagedResource = new IntPtr(12345); ///* allocate unmanaged resource */;
            managedResource = new FileStream("C:\\Users\\amert\\OneDrive\\Desktop\\gazebo.txt", FileMode.OpenOrCreate);///* allocate managed resource */;
        }

        // Implement IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected method to release resources
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources
                managedResource?.Dispose();
            }

            // Release unmanaged resources
            if (unmanagedResource != IntPtr.Zero)
            {
                /* release unmanaged resource */
                unmanagedResource = IntPtr.Zero;
            }
        }

        // Destructor (finalizer) to release unmanaged resources if Dispose() is not called
        ~ResourceHolder()
        {
            Dispose(false);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            using(ResourceHolder resourceHolder = new ResourceHolder()) 
            {

            }
        }
    }
}



