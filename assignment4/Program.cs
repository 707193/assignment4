using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        ArrayList Beowulf;
        private int area51;
        private int countSpaces;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            //Read files using StreamReader. Read file line by line 
            using (StreamReader file = new StreamReader("c:/area51/beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");

            }
        }


        public int FindNumberOfBlankSpaces(string line)
        {
            //http://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharpe
            int countletters = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}
