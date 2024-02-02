using System;

namespace project32
{
    public sealed class twoDimensionalArray: baseArray
    {
        private int[,] array;

        public twoDimensionalArray(bool isNotRandom): base(isNotRandom)
        {
            if (isNotRandom)
            {
                getFormUserArray();
            }
            else
            {
                getRandomArray();
            }
        }

        protected override void getFormUserArray()
        {
            Console.WriteLine("Ширина двумерного массива: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина двумерного массива: ");
            int width = int.Parse(Console.ReadLine());
            array = new int[width, length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите элемент с координатой ({j + 1}; {i + 1}): ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void getRandomArray()
        {
            Random random = new Random();
            int length = random.Next(3, 10);
            int width = random.Next(3, 10);
            array = new int[width, length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
        }

        public override void fillArray(bool isNotRandom)
        {
            if (isNotRandom)
            {
                getFormUserArray();
            }
            else
            {
                getRandomArray();
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