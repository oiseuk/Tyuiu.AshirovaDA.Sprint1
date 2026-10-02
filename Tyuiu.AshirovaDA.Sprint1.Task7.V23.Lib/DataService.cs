using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AshirovaDA.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double step1 = Math.Pow(10, Math.Sin(x));
            double step2 = (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            double step3 = Math.Cos(Math.Pow(x, 2) - y);

            double z = x - step1 + step2 + step3;
            return Math.Round(z, 3, MidpointRounding.AwayFromZero);
        }
    }
}