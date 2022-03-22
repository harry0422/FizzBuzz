using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 15;

            FizzBuzz fizzBuzz = new FizzBuzz(end);
            string result = fizzBuzz.RunFizzBuzz();

            Console.WriteLine(result);
        }
    }
}