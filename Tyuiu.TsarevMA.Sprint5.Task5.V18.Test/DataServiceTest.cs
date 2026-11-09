using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task5.V18.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task5.V18.Test\bin\Debug\InPutDataFileTask5V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}