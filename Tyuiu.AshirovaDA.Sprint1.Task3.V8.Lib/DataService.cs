using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AshirovaDA.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            double income = startAmount * (percent / 100.0) * (timeDays / 365.0);
            return Math.Round(income, 3, MidpointRounding.AwayFromZero);
        }
    }
}
