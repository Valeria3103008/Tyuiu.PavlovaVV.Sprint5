using System.IO;
using Tyuiu.PavlovaVV.Sprint5.Task5.V29.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"""C:\Users\leroc\source\repos\Tyuiu.PavlovaVV.Sprint5\DataSprint5\InPutDataFileTask5V29.txt""";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
