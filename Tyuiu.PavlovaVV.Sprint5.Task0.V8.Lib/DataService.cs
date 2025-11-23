using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PavlovaVV.Sprint5.Task0.V8.Lib
{
    public class DataService : ISprint5Task0V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = ((((double)x * (double)x * (double)x) - 1) / (4 * ((double)x * (double)x)));
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
