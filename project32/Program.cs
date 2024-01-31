using System;

namespace project32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baseArray[] arrays = new baseArray[3];
            arrays[0] = new oneDimensionalArray(false, 5, 0);
            arrays[1] = new twoDimensionalArray(false, 5, 10);
            arrays[2] = new jagged(false, 10, 0);
            
            for(int i = 0; i < arrays.Length; i++)
            {
                arrays[i].printArray();
                Console.WriteLine($"average value = {arrays[i].getAverageArrayValue()}");
            }
        }
    }    
}