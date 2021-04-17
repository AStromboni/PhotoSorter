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
