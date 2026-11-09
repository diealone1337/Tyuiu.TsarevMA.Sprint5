using System.IO;
using Tyuiu.TsarevMA.Sprint5.Task5.V18.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task5.V18
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService(); 

            string path = @"E:\Tyuiu.TsarevMA\repos\Tyuiu.TsarevMA.Sprint5.Task\Tyuiu.TsarevMA.Sprint5.Task5.V18.Test\bin\Debug\InPutDataFileTask5V18.txt";

            Console.Title = "Спринт #5 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл с набором значений. Найти произведение всех двузначных чисел    *");
            Console.WriteLine("* в файле. Полученный результат вывести на консоль. У вещественных        *");
            Console.WriteLine("* значений округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Путь к файлу: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Произведение двузначных чисел = " + res);

            Console.ReadKey();
        }
    }
}