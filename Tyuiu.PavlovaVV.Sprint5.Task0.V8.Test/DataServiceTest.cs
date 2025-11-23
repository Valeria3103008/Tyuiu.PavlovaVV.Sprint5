using System.IO;
using Tyuiu.PavlovaVV.Sprint5.Task0.V8.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\leroc\source\repos\Tyuiu.PavlovaVV.Sprint5\Tyuiu.PavlovaVV.Sprint5.Task0.V8\bin\Debug\net8.0";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}

