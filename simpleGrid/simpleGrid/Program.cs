using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGrid
{
    public class User
    {
        
    }
    class Program
    {
        private static void PopulateGrid(string fileName)
        {

            StreamWriter writer = new StreamWriter(fileName);
            // populate the string with 50 lines of 50i's (50x50);
            for (int y = 0; y < 25; y++)
            {
                string terrainLine = "";
                for (int i = 0; i < 25; i++)
                {
                    // 25 i's in terrainLine before being appended
                    terrainLine += "i";
                }
                writer.WriteLine(terrainLine);
            }
            writer.Close();
        }
        // lineChanger method for populating user usage: lineChanger("new text", "test.txt", randInt);
        static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private static void PopulateUser(string fileName)
        {
            
            string[] lines = File.ReadAllLines(fileName);
            int lineArrayLen = lines.Length;
            Random rand = new Random();
            // random line index
            int randInt = rand.Next(1, lineArrayLen);
            // get random line at rand index
            string randLine = lines[randInt];
            // builder new line with char in rand place
            int randChar = rand.Next(0, randLine.Length);
            StringBuilder strBuilder = new StringBuilder(randLine);
            strBuilder[randChar] = 'x';
            string newLine = strBuilder.ToString();

            LineChanger(newLine, fileName, randInt);
        }

        static void Main(string[] args)
        {
            string fileName = "text.txt";
            PopulateGrid(fileName);
            PopulateUser(fileName);
        }
    }
}
