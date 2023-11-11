using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01
{
    class Program
    {

        static void Main(string[] args)
        {
            string tjena = "Hej";
            string smile = " :)";
            string YourName;

            void Name()
            {
                Console.WriteLine("What is your name?");
                YourName = Console.ReadLine();
            }
            //      
            do
            {
                Name();
            }
            while (string.IsNullOrEmpty(YourName) || string.IsNullOrWhiteSpace(YourName));


            void Hello()
            {
                Console.WriteLine(tjena + ", hej " + YourName + smile);
                Console.WriteLine();
                Console.WriteLine();
            }

            Hello();






            //next exercise
            /*
            for (var i = 0; i < 10; i++)
            {
                Console.Write(i);
                if (i < 9)
                {
                    Console.Write(" - ");
                }

                if (i == 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("End of this excercise");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
            */
        }

    }

}
