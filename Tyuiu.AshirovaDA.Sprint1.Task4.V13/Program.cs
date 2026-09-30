//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле и печатает его на экране.
//формула:
//         cos(π/x)
//   --------------------
//        3 * e^(x+y)
using Tyuiu.AshirovaDA.Sprint1.Task4.V13.Lib;
namespace Tyuiu.AshirovaDA.Sprint1.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле cos(π/x) / (3·e^(x+y)) и печатает его     *");
            Console.WriteLine("* на экране. Ответ округлите до 3 знаков после запятой.                    *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine()!);

            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine()!);

            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* x = {x}");
            Console.WriteLine($"* y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}
    