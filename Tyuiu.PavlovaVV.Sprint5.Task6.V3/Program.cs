using Tyuiu.PavlovaVV.Sprint5.Task6.V3.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask6V3.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество латинских букв в заданной строке: {res}");
            Console.ReadKey();
        }
    }
}
