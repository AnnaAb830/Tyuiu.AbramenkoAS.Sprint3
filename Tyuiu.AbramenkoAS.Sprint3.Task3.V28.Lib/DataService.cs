using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbramenkoAS.Sprint3.Task3.V28.Lib
{

    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = "f35hyt t4j 3gkg45";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    str = str.Replace(c, 'r');
                }
            }
            return str;
        }
    }
}
