using System;

namespace project32
{
    public sealed class twoDimensionalArray: baseArray
    {
        private int[,] array;

        public twoDimensionalArray(bool isNotRandom, int length, int width)
        {
            if (isNotRandom)
            {
                array = new int[width, length];
                GetTwoDimensionalArray(array);
            }
            else
            {
                Random random = new Random();
                int ArrayLength = random.Next(3, 10);
                int ArrayWidth = random.Next(3, 10);
                array = new int[ArrayWidth, ArrayLength];
                GetTwoDimensionalArrayRandom(array);
            }
        }

        private int[,] GetTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        private int[,] GetTwoDimensionalArrayRandom(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            return array;
        }

        public override void fillArray(bool isNotRandom, int length, int width)
        {
            if (isNotRandom)
            {
                array = new int[width, length];
                GetTwoDimensionalArray(array);
            }
            else
            {
                Random random = new Random();
                int ArrayLength = random.Next(3, 10);
                int ArrayWidth = random.Next(3, 10);
                array = new int[ArrayWidth, ArrayLength];
                GetTwoDimensionalArrayRandom(array);
            }
        }
        
        public override double getAverageArrayValue()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum / array.Length;
        }

        public int[,] getTwoDimensionalArrayAsSanke()
        {
            int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        newArray[i, j] = array[i, j];
                    }
                    else
                    {
                        newArray[i, j] = array[i, array.GetLength(1) - j - 1];
                    }
                }
            }
            array = newArray;
            return newArray;
        }

        public override void printArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}