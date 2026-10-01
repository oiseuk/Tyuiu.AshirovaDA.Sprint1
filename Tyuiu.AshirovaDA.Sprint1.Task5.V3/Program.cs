using System;
using Tyuiu.AshirovaDA.Sprint1.Task5.V3.Lib;
//ЗАДАНИЕ
//Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k (например, если k=130985, то h=9).
namespace Tyuiu.AshirovaDA.Sprint1.Task5.V3
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
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #3                                                               *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                     *");
            Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи              *");
            Console.WriteLine("* положительного целого числа k (например, если k=130985, то h=9).         *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите целое число k: ");
            int k = int.Parse(Console.ReadLine()!);

            int result = ds.Calculate(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* k = {k}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* Третья от конца цифра = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}