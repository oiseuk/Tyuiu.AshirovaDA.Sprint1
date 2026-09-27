using Tyuiu.AshirovaDA.Sprint1.Task1.V27.Lib;
namespace Tyuiu.AshirovaDA.Sprint1.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression ()
        {
            DataService ds = new DataService ();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}
