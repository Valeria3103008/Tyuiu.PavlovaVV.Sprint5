using Tyuiu.PavlovaVV.Sprint5.Task3.V16.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine($"Значение функции y = {result}");
            Console.WriteLine($"Результат сохранён в файл: {path}");

            Console.ReadKey();
        }
    }
}
