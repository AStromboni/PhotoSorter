using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSorter.Core
{
    public interface IPhotoSource
    {
        IEnumerable<string> GetFilePaths();

        DateTime GetPhotoDateTimeFromPath(string path);
        string GetPhotoFileNameFromPath(string path);
    }
}
