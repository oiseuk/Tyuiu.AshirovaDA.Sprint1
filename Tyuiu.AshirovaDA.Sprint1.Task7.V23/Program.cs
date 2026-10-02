using Tyuiu.AshirovaDA.Sprint1.Task7.V23.Lib;

//Написать программу, которая вычисляет математическое выражение
//по исходным значениям данных, вводимых пользователем. 
//                       20x²
//  z = x - 10^sin(x) + ------ + cos(x² - y)
//                       3x³


namespace Tyuiu.AshirovaDA.Sprint1.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение           *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                    *");
            Console.WriteLine("*                       20x²                                                *");
            Console.WriteLine("* z = x - 10^sin(x) + ------- + cos(x² - y)                                *");
            Console.WriteLine("*                       3x³                                                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* x = {x}");
            Console.WriteLine($"* y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* z = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}