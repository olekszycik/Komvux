using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Numbers
    {
        public static void TwoNumbers()
        {
            Console.WriteLine("Giv me two numbers. \nNow first one:");
            string a = Console.ReadLine();
            Console.WriteLine("Next one: ");
            string b = Console.ReadLine();

            int result = Convert.ToInt32(a) + Convert.ToInt32(b);

            Console.WriteLine("Result: " + result);

        }

        public static void ThreeNumbers()
        {
            Console.WriteLine("Now giv me 3 numbers.\n" +
                "I add them and giv you avarage.\n" +
                "One after one (number, and after press Enter):");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();

            int sumOfThreeNumbers = Convert.ToInt32(n1) + Convert.ToInt32(n2) + Convert.ToInt32(n3);

            Console.WriteLine("Sum: " + sumOfThreeNumbers);

            int avgInt = AvarageOfThreeNumbers(sumOfThreeNumbers);
            Console.WriteLine("Avarage of 3 numbers is: " + avgInt);

            float avgFloat = AvarageOfThreeNumbersFloat(sumOfThreeNumbers);
            Console.WriteLine("Avarage of 3 numbers in float (4b) is: " + avgFloat);

            double avgDouble = AvarageOfThreeNumbersDouble(sumOfThreeNumbers);
            Console.WriteLine("Avarage of 3 numbers in double (8b) is: " + avgDouble);

            decimal avgDecimal = AvarageOfThreeNumbersDecimal(sumOfThreeNumbers);
            Console.WriteLine("Avarage of 3 numers in decimal (16b) is: " + avgDecimal);
        }

        public static int AvarageOfThreeNumbers(int data)
        {
            int avg = data / 3;
            return avg;
        }

        public static float AvarageOfThreeNumbersFloat(float data)
        {
            float avg = data / 3;
            return avg;
        }

        public static double AvarageOfThreeNumbersDouble(double data)
        {
            double avg = data / 3;
            return avg;
        }

        public static decimal AvarageOfThreeNumbersDecimal(decimal data)
        {
            decimal avg = data / 3;
            return avg;
        }
    }
}
