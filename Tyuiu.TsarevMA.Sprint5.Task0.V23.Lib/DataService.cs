using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TsarevMA.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            var path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            
            double y = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);
            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}