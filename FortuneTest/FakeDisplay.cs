using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTest
{
    public class FakeDisplay : IConsoleDisplay
    {
        public void ClearScreen(string prompt = "")
        {
            // does nothing in a test enviorment
        }

        public string PromptInput(string display, bool isInteger = false, string helpMessage = "")
        {
            //Returns the display parmeter
            return display;
        }

        public string ReadLine()
        {
            return "Read line";
        }

        public void Write(string line)
        {
            // does nothing in a test enviorment
        }

        public void WriteLine(string? line)
        {
            // does nothing in a test enviorment
        }
    }
}
