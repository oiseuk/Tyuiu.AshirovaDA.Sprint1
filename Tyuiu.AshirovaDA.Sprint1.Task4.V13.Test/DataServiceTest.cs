using Tyuiu.AshirovaDA.Sprint1.Task4.V13.Lib;
namespace Tyuiu.AshirovaDA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = -0.045;          // cos(π) / (3·e²) ≈ -0.045
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
