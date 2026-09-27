using Tyuiu.AshirovaDA.Sprint1.Task2.V6.Lib;

// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
// Известно расстояние в метрах. Перевести расстояние в километры
// Расстояние в метрах (целое число)
// Расстояние в километрах (вещественное число)

namespace Tyuiu.AshirovaDA.Sprint1.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Аширова Д. А. | РППб-26-1";

            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | Рппб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Известно расстояние в метрах. Перевести расстояние в километры.          *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите расстояние в метрах: ");
            int meters = int.Parse(Console.ReadLine()!);

            double result = ds.ConvertMToKm(meters);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* Расстояние = {meters} м");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine($"* {result} километров");
            Console.WriteLine("***************************************************************************");
        }
    }
}
