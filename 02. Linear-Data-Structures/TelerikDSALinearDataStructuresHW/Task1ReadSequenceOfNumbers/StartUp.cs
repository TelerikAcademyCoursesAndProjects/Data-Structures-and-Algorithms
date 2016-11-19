using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task1ReadSequenceOfNumbers
{
    public class StartUp
    {
        public static void Main()
        {

            BigInteger avarageOfNumbers = 0;
        }

        internal List<int> ReadingConsoleInput()
        {
            var input = Console.ReadLine();
            var listOfNumbers = new List<int>();

            while (input != string.Empty)
            {
                listOfNumbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            return listOfNumbers;
        }
        internal BigInteger SumingNumbers(List<int> listOfNumbers)
        {
            BigInteger sumOfNumbers = 0;
            sumOfNumbers = listOfNumbers.Sum();

            return sumOfNumbers;
        }
    }
}
