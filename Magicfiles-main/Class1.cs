using System;
using System.Collections.Generic;
using System.IO;    

namespace MagicFilesLib
{
    public interface IDirectoryExplorer

    {

        ICollection<string> GetFile(string path);

    }
    public class DirectoryExplorer 

    {
        IDirectoryExplorer _directoryExplorer;
       public DirectoryExplorer(IDirectoryExplorer directoryExplorer)
        {
            _directoryExplorer = directoryExplorer;
        }

        public ICollection<string> GetFiles(string path)

        {

            var files = _directoryExplorer.GetFile(path);

            return files;

        }

    }
}
