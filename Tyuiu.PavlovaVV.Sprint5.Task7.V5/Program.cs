using Tyuiu.PavlovaVV.Sprint5.Task7.V5.Lib;
namespace Tyuiu.PavlovaVV.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V5.txt");
            Console.WriteLine("Данныне находяться в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadDataAndSave(path));
        }
    }
}
