using Tyuiu.AshirovaDA.Sprint1.Task6.V2.Lib;
namespace Tyuiu.AshirovaDA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, world!";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidString_NoHello()
        {
            string strTest = "Hi, world!";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
