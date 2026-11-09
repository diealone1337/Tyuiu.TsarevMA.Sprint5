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

            string text = File.ReadAllText(path);
            string[] array = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < array.Length; i++)
            {
                string valueStr = array[i].Replace('.', ',');
                if (double.TryParse(valueStr, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out double temp))
                {
                    // Учитываем все числа в диапазоне от 10 до 99 (включая вещественные)
                    if (temp >= 10 && temp <= 99)
                    {
                        res *= temp;
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}