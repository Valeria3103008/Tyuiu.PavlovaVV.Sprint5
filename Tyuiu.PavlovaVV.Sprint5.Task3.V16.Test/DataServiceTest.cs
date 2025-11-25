using System.IO;
using Tyuiu.PavlovaVV.Sprint5.Task3.V16.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;

            double numerator = 2 * Math.Pow(x, 2) - 1;
            double denominator = Math.Sqrt(Math.Pow(x, 2) - 2);
            double wait = numerator / denominator;
            wait = Math.Round(wait, 3);

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Assert.AreEqual(wait, result);
        }
    }
}
