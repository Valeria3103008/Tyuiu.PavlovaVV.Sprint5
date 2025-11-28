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

            string path = @"C:\Users\leroc\source\repos\Tyuiu.PavlovaVV.Sprint5\DataSprint5";
            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Минимальное значение в файле: " + res);
            Console.ReadKey();
        }
    }
}
