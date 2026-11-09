using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevMA.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double y = (double)x / Math.Sqrt(Math.Pow(x, 2) + x);
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
