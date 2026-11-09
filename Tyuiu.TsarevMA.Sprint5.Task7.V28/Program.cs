using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task7.V28.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task7.V28.Test\bin\Debug\InPutDataFileTask7V28.txt";
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V28.txt");

            Console.Title = "Спринт #5 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту 5               *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл с набором символьных данных. Заменить все пробелы, идущие      *");
            Console.WriteLine("* подряд более одного, на один пробел. Полученный результат сохранить     *");
            Console.WriteLine("* в файл OutPutDataFileTask7V28.txt.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: " + path);

            if (File.Exists(path))
            {
                Console.WriteLine("Исходные данные:");
                Console.WriteLine(File.ReadAllText(path));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сохранено в файл:");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);

            Console.WriteLine();
            Console.WriteLine("Полученные данные:");
            if (File.Exists(res))
            {
                Console.WriteLine(File.ReadAllText(res));
            }

            Console.ReadKey();
        }
    }
}