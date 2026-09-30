using Tyuiu.AshirovaDA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AshirovaDA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500;   // величина вклада (руб.)
            double percent = 20;         // процентная ставка (% годовых)
            double timeDays = 30;        // срок вклада (дней)
            double wait = 41.096;         // ожидаемый доход
            var res = ds.IncomeAmount(startAmount, percent, timeDays);
            Assert.AreEqual(wait, res);
        }
    }
}
