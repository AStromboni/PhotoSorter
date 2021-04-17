using System;
using System.Collections.Generic;

namespace PhotoSorter.Core
{
    public interface IPhotoSource
    {
        IEnumerable<string> GetFilePaths();

        DateTime GetPhotoDateTimeFromPath(string path);
        string GetPhotoFileNameFromPath(string path);
    }
}
