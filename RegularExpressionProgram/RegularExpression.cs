using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionProgram
{
    public class RegularExpression              //Created class
    {
        public static void TestPattern(string pattern, string[] arr)            //Created TestPattern method
        {
            foreach (string inputs in arr)
            {
                if (Regex.IsMatch(inputs, pattern))
                {
                    Console.WriteLine("{0} is valid", inputs);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", inputs);
                }
            }
        }
        public static void validatePinCode()            //Create valide pin code method
        {
            string pattern = "^[0-9]{6}";
            string[] arr = { "400088" };
            TestPattern(pattern, arr);
        }
    }
}
