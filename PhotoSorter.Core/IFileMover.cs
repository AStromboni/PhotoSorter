using System;

namespace PhotoSorter.Core
{
    public interface IFileMover
    {
        void MoveFile(string sourcePath, string destinationPath);

        string ComputeDestinationPath(string sourcePath, DateTime imageDateTime, string fileName);

    }
}
