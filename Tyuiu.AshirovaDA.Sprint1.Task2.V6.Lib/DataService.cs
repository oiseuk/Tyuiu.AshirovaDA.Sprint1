using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AshirovaDA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int meters)
        {
            DataService ds = new DataService();
            double kilometers = meters / 1000.0;
            return Math.Round(kilometers, 3, MidpointRounding.AwayFromZero);
        }
    }
}
