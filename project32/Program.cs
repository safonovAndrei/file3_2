using System;

namespace project32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baseArray[] arrays = new baseArray[3];

            Console.WriteLine("Ввести массивы не случайно? (Yes, No): ");
            string answer = Console.ReadLine();
            bool userAnswer;
            if(answer == "Yes")
            {
                userAnswer = true;
            }
            
            else
            {
                userAnswer = false;
            }
            
            arrays[0] = new oneDimensionalArray(userAnswer);
            arrays[1] = new twoDimensionalArray(userAnswer);
            arrays[2] = new jagged(userAnswer);            

            for(int i = 0; i < arrays.Length; i++)
            {
                arrays[i].printArray();
                Console.WriteLine($"average value = {arrays[i].getAverageArrayValue()}");
            }
        }
    }    
}