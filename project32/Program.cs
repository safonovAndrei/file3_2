using System;

namespace project32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baseArray[] arrays = new baseArray[3];

            Console.WriteLine("Ввести массивы не случайно? (Yes, No): ");
            if(Console.ReadLine() == "Yes")
            {
                arrays[0] = new oneDimensionalArray(true);
                arrays[1] = new twoDimensionalArray(true);
                arrays[2] = new jagged(true);
            }
            
            else
            {
                arrays[0] = new oneDimensionalArray(false);
                arrays[1] = new twoDimensionalArray(false);
                arrays[2] = new jagged(false);
            }

            for(int i = 0; i < arrays.Length; i++)
            {
                arrays[i].printArray();
                Console.WriteLine($"average value = {arrays[i].getAverageArrayValue()}");
            }
        }
    }    
}