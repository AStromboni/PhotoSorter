using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSorter.Core
{
    public interface IFileMover
    {
        void MoveFile(string sourcePath, string destinationPath);

        string ComputeDestinationPath(string sourcePath, DateTime imageDateTime, string fileName);
        
    }
}
