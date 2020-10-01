using System;

namespace DoTheMath
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a simple equation with the numbers and operater all seperated by a space. (+,-,/,*,^,%)");
                string userString = Console.ReadLine();
                string[] splitUserString = userString.Split(" ");
                int userNum1 = Convert.ToInt32(splitUserString[0]);
                int userNum2 = Convert.ToInt32(splitUserString[2]);
                if (splitUserString[1] == "+")
                {
                    Console.WriteLine("The sum is: " + (userNum1 + userNum2));
                }
                if (splitUserString[1] == "-")
                {
                    Console.WriteLine("The difference is: " + (userNum1 - userNum2));
                }
                if (splitUserString[1] == "*")
                {
                    Console.WriteLine("The product is: " + (userNum1 * userNum2));
                }
                if (splitUserString[1] == "/")
                {
                    Console.WriteLine("The quotient is: " + (userNum1/userNum2));
                }
                if (splitUserString[1] == "^")
                {
                    Console.WriteLine("The simplified exponent is: " + Math.Pow(userNum1,userNum2));
                }
                if (splitUserString[1] == "%")
                {
                    Console.WriteLine("The remainder is: " + (userNum1%userNum2));
                }
            }
        }
    }
}
