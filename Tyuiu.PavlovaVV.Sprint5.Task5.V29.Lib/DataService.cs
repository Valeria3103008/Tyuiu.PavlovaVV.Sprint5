using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PavlovaVV.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double Min = int.MaxValue;
                double MinRes = int.MaxValue;
                while ((line = reader.ReadLine()) != null)
                {
                    double temp = Convert.ToDouble(line);
                    if ((temp <= Min) && (temp >= 10 && temp < 100))
                    {
                        Min = Convert.ToInt32(line);
                        MinRes = Convert.ToDouble(line);
                    }
                }
                return MinRes;
            }
        }
    }
}
