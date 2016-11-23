using System;

namespace Task1NNestedLoops
{
    public class NestedLoopsStartUp
    {
        public static void NestedLoopsSimulationWithRecursion(int number)
        {
            int startNumber = 1;
            int endNumber = number;
            int[,] matrix = new int[endNumber, endNumber];

                matrix[number, number] = startNumber;

                NestedLoopsSimulationWithRecursion(number);
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            NestedLoopsSimulationWithRecursion(number);
        }
    }
}
