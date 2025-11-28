using Tyuiu.PavlovaVV.Sprint5.Task5.V29.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + res);
            Console.ReadKey();
        }
    }
}
