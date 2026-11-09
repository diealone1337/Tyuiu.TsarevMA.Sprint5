using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevMA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            double x = double.Parse(strX);

            double y = Math.Cos(x) + Math.Pow(x, 2) - (2 * x) / 1.2;
            y = Math.Round(y, 3);

            return y;
        }
    }
}
