using System.IO;
using Tyuiu.PavlovaVV.Sprint5.Task1.V17.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\leroc\source\repos\Tyuiu.PavlovaVV.Sprint5\Tyuiu.PavlovaVV.Sprint5.Task1.V17\bin\Debug\net8.0";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
