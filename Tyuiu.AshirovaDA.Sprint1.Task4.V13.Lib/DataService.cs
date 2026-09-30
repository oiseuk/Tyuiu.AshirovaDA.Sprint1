using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AshirovaDA.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            var res = 1 / (Math.Pow(x, 2) + Math.Pow(y, 2));
            return res;
        }
    }
}
