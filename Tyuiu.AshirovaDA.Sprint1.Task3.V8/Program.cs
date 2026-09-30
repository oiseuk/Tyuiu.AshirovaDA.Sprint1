using Tyuiu.AshirovaDA.Sprint1.Task3.V8.Lib;

//ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
// Расчеты: Написать программу вычисления величины дохода по вкладу.
// Процентная ставка (% годовых) и время хранения (дней) задаются во время работы программы.

namespace Tyuiu.AshirovaDA.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
   
            Console.Title = "Спринт #1 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                 *");
            Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются           *");
            Console.WriteLine("* во время работы программы. Ответ округлите до 3 знаков после запятой.    *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите величину вклада (руб.): ");
            double startAmount = double.Parse(Console.ReadLine()!);

            Console.Write("Введите процентную ставку (% годовых): ");
            double percent = double.Parse(Console.ReadLine()!);

            Console.Write("Введите срок вклада (дней): ");
            double timeDays = double.Parse(Console.ReadLine()!);
            DataService ds = new DataService();
            double result = ds.IncomeAmount(startAmount, percent, timeDays);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* Величина вклада = {startAmount} руб.");
            Console.WriteLine($"* Процентная ставка = {percent} % годовых");
            Console.WriteLine($"* Срок вклада = {timeDays} дней");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine($"* Доход по вкладу = {result} руб.");
            Console.WriteLine("***************************************************************************");
        }
    }
}