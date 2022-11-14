using System;

namespace FizzBuzzChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a whole number to see if it is divisible by 3 or 5...");
            int number = int.Parse(Console.ReadLine());
            FizzBuzz(number);

        }   

            public static string FizzBuzz(int number)
            {
                var answer = "";

                if (number % 3 == 0)
                {
                    answer = "fizz";
                    Console.WriteLine("This number is divisible by 3.");
                }

                if (number % 5 == 0)
                {
                    answer += "buzz";
                    Console.WriteLine("This number is divisible by 5.");
                }

                Console.WriteLine(answer);
                return answer;


            }


            

        
    }
}
