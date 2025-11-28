using Tyuiu.PavlovaVV.Sprint5.Task7.V5.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V5.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V5.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Все латинские буквы из файла были удалены = " + pathSaveFile);
            Console.ReadKey();
        }
    }
}
