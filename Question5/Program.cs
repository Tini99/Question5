using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("please enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter third number");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("number1," + Convert.ToString(number1) + "is the greater number");
            }

            if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("number2," + Convert.ToString(number2) + "is the greater number");
            }
            if (number3 > number2 && number3 > number1)
            {
                Console.WriteLine("number3," + Convert.ToString(number3) + "is the greater number");
            }
        }
    }
}
