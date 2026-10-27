using Tyuiu.AbramenkoAS.Sprint3.Task4.V17.Lib;

namespace Tyuiu.AbramenkoAS.Sprint3.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stoptValue = 5;
            double res = ds.Calculate(startValue, stoptValue);
            double wait = 0.527;
            Assert.AreEqual(wait, res);
        }
    }
}
