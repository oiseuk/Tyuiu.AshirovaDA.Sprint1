using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AshirovaDA.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            // Проверяем, содержит ли строка слово "Hello"
            return value.Contains("Hello");
        }
    }
}
