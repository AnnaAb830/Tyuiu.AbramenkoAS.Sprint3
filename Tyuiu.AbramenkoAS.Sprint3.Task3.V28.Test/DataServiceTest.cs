using Tyuiu.AbramenkoAS.Sprint3.Task3.V28.Lib;

namespace Tyuiu.AbramenkoAS.Sprint3.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string str = "f35hyt t4j 3gkg45";
            string res = ds.ReplaceNumOnChar(str, 'r');
            string wait = "frrhyt trj rgkgrr";
            Assert.AreEqual(wait, res);

        }
    }
}
