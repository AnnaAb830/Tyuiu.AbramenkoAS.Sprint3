using Tyuiu.AbramenkoAS.Sprint3.Task7.V8.Lib;

namespace Tyuiu.AbramenkoAS.Sprint3.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых решений по спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 5:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}
