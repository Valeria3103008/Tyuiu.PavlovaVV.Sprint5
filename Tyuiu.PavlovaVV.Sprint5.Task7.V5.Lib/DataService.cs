using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PavlovaVV.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string pS = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V5.txt");
            FileInfo fileInfo = new FileInfo(pS);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pS);
            }
            string strLine = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'H') && (line[i] != 'e') && (line[i] != 'l') && (line[i] != 'o') && (line[i] != 'I') && (line[i] != 's') && (line[i] != 'M') && (line[i] != 'y') && (line[i] != 'F') && (line[i] != 'i') && (line[i] != 'r') && (line[i] != 't') && (line[i] != 's') && (line[i] != 'P') && (line[i] != 'g') && (line[i] != 'a') && (line[i] != 'm'))
                        {
                            strLine = strLine + line[i];
                        }
                    }
                }
                strLine = strLine.Replace("    .", ".");
                File.AppendAllText(pS, strLine + Environment.NewLine);
                strLine = "";
            }
            return pS;
        }
    }
}
