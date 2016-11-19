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
        internal static List<int> ReadingConsoleInput(string input)
        {
            var listOfNumbers = new List<int>();

            while (input != string.Empty)
            {
                listOfNumbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            return listOfNumbers;
        }
        internal static BigInteger FindSumOfNumbers(List<int> listOfNumbers)
        {
            var sumOfNumbers = 0;
            sumOfNumbers = listOfNumbers.Sum();

            return sumOfNumbers;
        }

        internal static double FindAvarageOfNumbers(List<int> listOfNumbers)
        {
            var avagrageOfNumbers = listOfNumbers.Average();

            return avagrageOfNumbers;
        }

        public static void Main()
        {
            var listOfNumbers = ReadingConsoleInput(Console.ReadLine());
            var sumOfNumbers = FindSumOfNumbers(listOfNumbers);
            var avagrageOfNumbers = FindAvarageOfNumbers(listOfNumbers);
        }
    }
}
