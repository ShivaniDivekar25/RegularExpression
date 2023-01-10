using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionProgram
{
    internal class RegularExpression
    {
        public static void validatePinCode()            //Created validate pin code method
        {
            string pattern = "^[0-9]{3}[ ]?[0-9]{3}$";
            string[] arr = { "400088", "A400088","400088B","400 088" };
            TestPattern(pattern, arr);
        }
        public static void validateEmail()          //Created validate email method
        {
            string pattern = "^[a-zA-z]{3}[.,+,_,-]{1}[a-zA-Z]{2,}@[a-zA-Z]{1,10}.[a-zA-Z]{2}.[a-zA-z]{2}";
            string[] arr = {"abc_xyz@bridgelabz.co.in"};
            TestPattern(pattern, arr);
        }
        public static void TestPattern(string pattern, string[] arr)            //Created Test pattern method
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
    }
}
