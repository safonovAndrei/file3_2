using System;

namespace project32
{
    
    public sealed class oneDimensionalArray: baseArray 
    {

        private bool isNotRandom = false;
        private int[] array;

        public oneDimensionalArray(bool isNotRandom) : base(isNotRandom)
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

        protected override void getRandomArray()
        {
            Random random = new Random();
            array = new int[random.Next(1, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                int value = random.Next(-250, 250);
                array[i] = value;
            }
        }

        protected override void getFormUserArray()
        {
            Console.Write("Длина одномерного массива: ");
            array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                array[i] = int.Parse(Console.ReadLine());
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
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public int[] deleteBiggerThan100()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    count += 1;
                }
            }
            int[] new_array = new int[count];
            int count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    new_array[count2] = array[i];
                    count2++;
                }
            }
            array = new_array;
            return new_array;
        }

        public int[] deleteRepeating()
        {
            int count = 0;
            bool isUnique = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j && array[i] == array[j])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    count++;
                }
                isUnique = true;
            }
            int[] new_array = new int[count];
            int count1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j && array[i] == array[j])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    new_array[count1] = array[i];
                    count1++;
                }
                isUnique = true;
            }
            array = new_array;
            return new_array;
        }

        public override void printArray() 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}; ");
            }
            Console.WriteLine(" ");
        }
    }
}