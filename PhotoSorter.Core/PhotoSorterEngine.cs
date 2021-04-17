using System;

namespace PhotoSorter.Core
{
    public sealed class PhotoSorterEngine
    {
        private readonly IFileMover _fileMover;
        private readonly IPhotoSource _photoSource;
        private readonly IUserInterface _userInterface;


        public PhotoSorterEngine(IFileMover fileMover, IPhotoSource photoSource, IUserInterface userInterface)
        {
            _fileMover = fileMover;
            _photoSource = photoSource;
            _userInterface = userInterface;
        }

        public void Run()
        {
            try
            {
                int imageCount = 0;
                _userInterface.WriteMessage("Le rangement des fichiers commence.");
                foreach (var sourcePath in _photoSource.GetFilePaths())
                {
                    var imageDateTime = _photoSource.GetPhotoDateTimeFromPath(sourcePath);
                    var imageFileName = _photoSource.GetPhotoFileNameFromPath(sourcePath);

                    var targetPath = _fileMover.ComputeDestinationPath(sourcePath, imageDateTime, imageFileName);
                    _fileMover.MoveFile(sourcePath, targetPath);

                    imageCount++; ;

                }

                _userInterface.WriteMessage(String.Format("Le rangement de {0} fichier(s) est terminé.",imageCount));


            }
            catch(Exception e)
            {
                _userInterface.WriteError("Une erreur s'est produite pendant le traitement :");
                _userInterface.WriteError(e.Message);
                _userInterface.WriteError(e.StackTrace);
                
            }
            
        }
    }
}
