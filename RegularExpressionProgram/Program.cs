namespace RegularExpressionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression program");
            Console.WriteLine("Please enter the option given below");               //Taking user input
            Console.WriteLine("1:Create PIN code\n2:Restrict alphabates at beginning of Pin Code\n3:Restrict alphabates at end of Pin Code");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //Create switch case to call different methods
            {
                case 1:
                    RegularExpression.validatePinCode();
                    break;
                case 2:
                    RegularExpression.validatePinCode();
                    break;
                case 3:
                    RegularExpression.validatePinCode();
                    break;
                default:
                    Console.WriteLine("Plaese choose correct option");
                    break;
            }

        }
    }
}