using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TsarevMA.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        // Проверяем, является ли символ строчной латинской буквой (от 'a' до 'z')
                        if (line[i] >= 'a' && line[i] <= 'z')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
