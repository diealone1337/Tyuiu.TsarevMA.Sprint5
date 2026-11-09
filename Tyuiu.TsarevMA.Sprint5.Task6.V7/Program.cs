using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task6.V7.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task6.V7.Test\bin\Debug\InPutDataFileTask6V7.txt";

            Console.Title = "Спринт #5 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл с набором символьных данных. Найти количество строчных          *");
            Console.WriteLine("* латинских букв в заданной строке.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Путь к файлу: " + path);

            if (File.Exists(path))
            {
                Console.WriteLine("Данные в файле: " + File.ReadAllText(path));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество строчных латинских букв = " + res);

            Console.ReadKey();
        }
    }
}
