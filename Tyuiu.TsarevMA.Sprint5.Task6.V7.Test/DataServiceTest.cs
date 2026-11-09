using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task6.V7.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile() 
        {
            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task6.V7.Test\bin\Debug\InPutDataFileTask6V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedCalc()
        {
            DataService ds = new DataService();
            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task6.V7.Test\bin\Debug\InPutDataFileTask6V7.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "abc ABC 123 xyz");
            }

            int res = ds.LoadFromDataFile(path);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}