using Tyuiu.AshirovaDA.Sprint1.Task0.V18.Lib;
namespace Tyuiu.AshirovaDA.Sprint1.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
