using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task0.V23.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
