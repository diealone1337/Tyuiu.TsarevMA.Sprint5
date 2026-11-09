using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task7.V28.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task7.V28.Test\bin\Debug\InPutDataFileTask7V28.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Test   string   with   spaces.");
            }

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedCalc()
        {
            DataService ds = new DataService();
            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task7.V28.Test\bin\Debug\InPutDataFileTask7V28.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Test   string   with   spaces.");
            }

            string res = ds.LoadDataAndSave(path);
            bool fileExists = File.Exists(res);
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}