using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PavlovaVV.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (res > Convert.ToDouble(line))
                    {
                        res = Convert.ToDouble(line);
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
