using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task4.V16.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V16.txt");
           
            File.WriteAllText(path, "1,5");

            Console.Title = "Спринт #5 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл с вещественным значением. Прочитать значение из файла и         *");
            Console.WriteLine("* подставить вместо X в формуле y = cos(x) + x^2 - (2x)/1.2. Вычислить      *");
            Console.WriteLine("* значение, округлить до трех знаков и вернуть на консоль.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("Данные в файле: " + File.ReadAllText(path));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат вычислений Y = " + res);

            Console.ReadKey();
        }
    }
}