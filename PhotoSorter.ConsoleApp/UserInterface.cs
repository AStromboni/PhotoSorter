using PhotoSorter.Core;
using System;

namespace PhotoSorter.ConsoleApp
{
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
