using System;

namespace LeadersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leaders in an array!");
            Console.WriteLine("--------------------");

            int[] inputArray = GetArrayFromInput();
            PrintLeadersInArray(inputArray);

            Console.ReadLine();
        }

        private static int[] GetArrayFromInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                array = new int[noElements];
                for (int index = 0; index < array.Length; index++) {
                    array[index] = int.Parse(elements[index]);
                }

            }
            catch (Exception exception) {
                Console.WriteLine("GetArrayFromInput(): Exception thrown is "+exception.Message);
            }


            return array;
        }


        private static void PrintLeadersInArray(int[] array) {
            int maxSoFar = array[(array.Length - 1)];

            Console.WriteLine("---Printing the leaders in the array-----");

            for (int index = array.Length - 2; index >= 0; index--) {
                if (array[index] > maxSoFar) {
                    Console.Write(array[index]+" ");
                    maxSoFar = array[index];
                }
            }

            Console.WriteLine();
        }
    }
}
