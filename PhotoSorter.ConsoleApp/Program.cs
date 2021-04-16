using Photosorter.Windows;
using PhotoSorter.Core;
using System;

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

    class UserInterface : IUserInterface
    {
        public string ReadMessage()
        {
            return Console.ReadLine();
        }

        public string ReadMessage(string promptMessage)
        {
            WriteMessage(promptMessage);
            return ReadMessage();
        }

        public void WriteError(string message)
        {
            var color = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine(message);
            }
            finally
            {
                Console.ForegroundColor = color;
            }
            
            
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
