using PhotoSorter.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSorter.Windows
{
    public class FileMover : IFileMover
    {
        private readonly string _destinationPath;

        public FileMover(string destinationPath)
        {
            _destinationPath = destinationPath;
        }

        public string ComputeDestinationPath(string sourcePath, DateTime imageDateTime, string fileName)
        {
            


            return Path.Combine(_destinationPath, imageDateTime.ToString("yyyy-MM-dd"), fileName);

        }

        public void MoveFile(string sourcePath, string destinationPath)
        {
            var fileInfo = new FileInfo(destinationPath);
            fileInfo.Directory.Create();
            File.Move(sourcePath, destinationPath);
        }
    }
}
