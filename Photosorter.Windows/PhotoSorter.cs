﻿using PhotoSorter.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photosorter.Windows
{
    public class PhotoSource : IPhotoSource
    {
        private readonly string _sourcePath;

        public PhotoSource(string sourcePath)
        {
            _sourcePath = sourcePath;
        }

        public IEnumerable<string> GetFilePaths()
        {
            var info = new DirectoryInfo(_sourcePath);
            return info.GetFiles("*", SearchOption.AllDirectories).Select((i)=>i.FullName);

        }

        public DateTime GetPhotoDateTimeFromPath(string path)
        {
            var info = new FileInfo(path);
            return info.CreationTime;
        }

        public string GetPhotoFileName(string path)
        {
            var info = new FileInfo(path);
            return info.Name;
        }

    }
}
