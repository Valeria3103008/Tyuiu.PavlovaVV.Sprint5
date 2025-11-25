using Tyuiu.PavlovaVV.Sprint5.Task2.V30.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { { 3, -1, -3 },
                                         {-2, -5, 0 },
                                         { -8, -7, 2 }};
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                string res = ds.SaveToFileTextData(mtrx);

                Console.WriteLine("Файл: " + res);
                Console.WriteLine("Создан!");
                Console.ReadKey();
            }
        }
    }
}
