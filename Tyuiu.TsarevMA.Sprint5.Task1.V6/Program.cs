using Tyuiu.TsarevMA.Sprint5.Task1.V6.Lib;

namespace Tyuiu.TsarevMA.Sprint5.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #5 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дана функция F(x) = cos(x) + (4x)/2 - sin(x) * 3x (произвести            *");
            Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.            *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести      *");
            Console.WriteLine("* на консоль в таблицу. Значения округлить до двух знаков после запятой.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(X)   |");
            Console.WriteLine("+----------+----------+");

            int currentX = startValue;
            string[] lines = System.IO.File.ReadAllLines(res);

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("|{0,9} |{1,10} |", currentX, lines[i]);
                currentX++;
            }
            Console.WriteLine("+----------+----------+");

            Console.WriteLine();
            Console.WriteLine("Файл сохранен по пути: " + res);

            Console.ReadKey();
        }
    }
}
