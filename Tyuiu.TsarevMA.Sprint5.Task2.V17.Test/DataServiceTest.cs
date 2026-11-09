using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task2.V17.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 2, 1, 7 }, { 1, 2, 4 }, { 2, 3, 4 } };
            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}