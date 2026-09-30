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
            double x = 3;
            double y = 4;
            double wait = 0.04;          // 1 / (9 + 16) = 1/25 = 0.04
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
