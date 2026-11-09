using System.Globalization; 
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TsarevMA.Sprint5.Task5.V18.Lib 
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] array = line.Split(' ');
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(array[i]))
                        {
                            
                            double temp = Convert.ToDouble(array[i].Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

                            
                            if (temp >= 10 && temp <= 99 && temp % 1 == 0)
                            {
                                res *= temp;
                            }
                        }
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}