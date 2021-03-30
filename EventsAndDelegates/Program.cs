using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class DownloadHelper
    {
        // Step 1 - create a delegate
        public delegate void FileDownloadedEventHandler(object source, EventArgs args);

        // Step 2 - create an event based on the delegate
        public event FileDownloadedEventHandler FileDownloaded;

        //Step 3 - raise the event

        protected virtual void OnFileDownloaded()
        {
            if(FileDownloaded != null)
            {
                FileDownloaded(this, EventArgs.Empty);
            }
        }
        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            //Step 3.1
            OnFileDownloaded();
        }
    }
}
