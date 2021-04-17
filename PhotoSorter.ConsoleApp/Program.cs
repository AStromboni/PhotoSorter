using PhotoSorter.Windows;
using PhotoSorter.Core;

namespace PhotoSorter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterface userInterface = new UserInterface();

            
            if (args.Length < 2)
            {
                userInterface.WriteError("Merci de fournir : le dossier de lecture des images, et le dossier de rangement des images");
                return;
            }
            var sourceFolder = args[0];
            var targetFolder = args[1];

            IPhotoSource source = new PhotoSource(sourceFolder);
            IFileMover mover = new FileMover(targetFolder);
            

            var engine = new PhotoSorterEngine(mover, source, userInterface);

            engine.Run();

        }
    }
}
