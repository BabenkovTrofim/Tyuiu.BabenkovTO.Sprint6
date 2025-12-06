using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabenkovTO.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains("n") == true || word.Contains("N") == true)
                        {
                            resStr += word + " ";
                        }
                    }
                }
            }
            return resStr.Trim();
        }
    }
}
