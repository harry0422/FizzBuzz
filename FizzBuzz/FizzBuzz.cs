using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private readonly IEnumerable<int> _numbers;
        public FizzBuzz(int end, int start = 0)
        {
            if (start > end)
            {
                throw new Exception("Start must be less end.");
            }
            _numbers = Enumerable.Range(start + 1, end - start).ToList();
        }
        public string RunFizzBuzz()
        {
            var result = new StringBuilder();

            _numbers.ToList().ForEach(number => 
            {
                var line = string.Empty;

                line += (number % 3 == 0) ? "Fizz" : string.Empty;
                line += (number % 5 == 0) ? "Buzz" : string.Empty;
                line += (number % 3 != 0 && number % 5 != 0) ? number.ToString() : string.Empty;

                result.AppendLine(line);
            });

            return result.ToString();
        }
    }
}
