using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            List<string> wordsWithn = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string[] Words;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Words = line.Split();
                    foreach (string word in Words)
                    {
                        if (word.Contains('n'))
                        {
                            wordsWithn.Add(word);
                        }
                    }
                }
            }

            return String.Join(" ", wordsWithn);
        }
    }
}
