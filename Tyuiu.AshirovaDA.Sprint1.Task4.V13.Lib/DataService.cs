using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AshirovaDA.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Cos(Math.PI / x);
            double denominator = 3 * Math.Exp(x + y);
            return Math.Round(numerator / denominator, 3, MidpointRounding.AwayFromZero);
        }
    }
}
