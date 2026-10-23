using Tyuiu.AbramenkoAS.Sprint3.Task2.V7.Lib;

namespace Tyuiu.AbramenkoAS.Sprint3.Task2.V7.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 81.083;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
