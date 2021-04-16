using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSorter.Core
{
    public interface IUserInterface
    {
        void WriteMessage(string message);
        void WriteError(string message);

        string ReadMessage();
        string ReadMessage(string promptMessage);
    }
}
