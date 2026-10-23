using Tyuiu.AbramenkoAS.Sprint3.Task1.V3.Lib;

namespace Tyuiu.AbramenkoAS.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 24589.408;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
