using System.Collections.Generic;
using System.IO;

namespace CalculationsLibrary
{
    public interface ITextDataAccess
    {
        void SaveText(string filePath, List<string> lines);

    }

    public class TextDataAccess : ITextDataAccess
    {
        public void SaveText(string filePath, List<string> lines)
        {
            if (filePath.Length > 260)
            {
                throw new PathTooLongException("The path needs to be less than 261 characters long.");
            }

            string fileName = Path.GetFileName(filePath);

            File.WriteAllLines(fileName, lines);

        }
    }
}
