namespace FortuneTeller
{
    public interface IConsoleDisplay
    {
        void ClearScreen(string prompt = "");
        string PromptInput(string display, bool isInteger = false, string helpMessage = "");
        string ReadLine();
        void Write(string line);
        void WriteLine(string? line = null);
    }
}