using System;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string FizzBuzzerate(int n) {
            var returnString = new StringBuilder("");

            if (n%3 == 0) {
                returnString.Append("fizz");
            }

            if (n%5 == 0) {
                returnString.Append("buzz");
            }

            if (returnString.Length > 0) {
                return returnString.ToString();
            }

            return n.ToString();
        }
    }
}
