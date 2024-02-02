using System;

namespace project32
{
    public sealed class jagged: baseArray
    {
        private int[][] array;

        public jagged(bool isNotRandom): base(isNotRandom)
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
            Console.WriteLine("Введите кол-во массивов в ступенчатом массиве: ");
            array = new int[int.Parse(Console.ReadLine())][];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите количество элементов для {i + 1} массива: ");
                array[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"Ввдеите {j + 1} число для {i + 1} массива: ");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void getRandomArray()
        {
            Random random = new Random();
            int numberOfArrays = random.Next(3, 10);
            array = new int[numberOfArrays][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[random.Next(3, 10)];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(3, 10);
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
            int length = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    length += 1;
                }
            }
            return sum / length;
        }

        public double[] getAverageArrayJaggedValue()
        {
            double[] arrayJaggedAverageValue = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                int length = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    length += 1;
                }
                arrayJaggedAverageValue[i] = sum / length;
            }
            return arrayJaggedAverageValue;
        }

        public int[][] changeEvenInJagged()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            return array;
        }
        
        public override void printArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}