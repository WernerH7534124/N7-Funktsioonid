using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Sisestage esimene arv: ");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisestage tehte teine arv: ");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisestage tehte tüüp('+', '-', '*' või '/'): ");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch(userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubstractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Ole tähelepanelikum! - Kena päeva!");
                    break;
            }
        }
        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
        public static void SubstractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }
    }
}
