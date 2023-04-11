class Resource : IDisposable  
    {  
        private bool disposed = false;  
        public void Dispose()  
        {  
            Dispose(true);  
            GC.SuppressFinalize(this);  
        }  
  
        private void Dispose(bool disposing)  
        {  
            if (!disposed)  
            {  
                if (disposing)  
                {  
                    // can clean up other managed objects  
                }  
                // clean up unmanaged resources  
                disposed = true;  
            }  
        }  
        ~Resource()  
        {  
            Dispose(false);  
        }  
    }  
    class Program  
    {  
        static void Main()  
        {  
            Resource resource = null;  
            try  
            {  
                resource = new Resource();  
                // use resource  
            }  
            finally  
            {  
                if (resource != null)  
                {  
                    resource.Dispose();  
                }  
            }  
        }  
    }  
