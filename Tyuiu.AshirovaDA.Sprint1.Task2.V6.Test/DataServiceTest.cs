using Tyuiu.AshirovaDA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.AshirovaDA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int meters = 2500;
            var res = ds.ConvertMToKm(meters);
            Assert.AreEqual(2.5, res);

        }
    }
}
