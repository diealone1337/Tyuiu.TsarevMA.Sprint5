using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TsarevMA.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);

            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string resStr = string.Join(" ", words);

            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V28.txt");

            if (File.Exists(pathSave))
            {
                File.Delete(pathSave);
            }

            File.WriteAllText(pathSave, resStr);

            return pathSave;
        }
    }
}