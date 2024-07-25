using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace FileZillaClone
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Example data for local files
            LocalFilesListView.ItemsSource = new List<FileInfo>
            {
                new FileInfo { Name = "file1.txt", Size = "14 KB", DateModified = "2024-07-23" },
                new FileInfo { Name = "file2.jpg", Size = "1.2 MB", DateModified = "2024-07-22" }
            };

            // Example data for remote files
            RemoteFilesListView.ItemsSource = new List<FileInfo>
            {
                new FileInfo { Name = "remote1.txt", Size = "16 KB", DateModified = "2024-07-23" },
                new FileInfo { Name = "remote2.png", Size = "2.4 MB", DateModified = "2024-07-21" }
            };

            // Example data for transfer queue
            TransferQueueListView.ItemsSource = new List<TransferQueueItem>
            {
                new TransferQueueItem { File = "file1.txt", Status = "Queued", Progress = "50%" },
                new TransferQueueItem { File = "remote1.txt", Status = "Downloading", Progress = "20%" }
            };
        }
    }
}