using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task4.V16.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V16.txt");
            File.WriteAllText(path, "1,5");

            Tyuiu.TsarevMA.Sprint5.Task4.V16.Lib.DataService ds = new Tyuiu.TsarevMA.Sprint5.Task4.V16.Lib.DataService();
            double res = ds.LoadFromDataFile(path);
            double wait = -0.179;

            Assert.AreEqual(wait, res);
        }
    }
}