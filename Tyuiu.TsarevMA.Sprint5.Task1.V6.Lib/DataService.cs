using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TsarevMA.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    y = Math.Cos(x) + (4.0 * x) / 2.0 - Math.Sin(x) * 3 * x;
                    if (double.IsNaN(y) || double.IsInfinity(y))
                    {
                        y = 0;
                    }
                }
                catch
                {
                    y = 0;
                }

                y = Math.Round(y, 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}