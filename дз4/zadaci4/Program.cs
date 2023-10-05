using System;

namespace Tasks
{
    class Program
    {
        static void swap(ref int x, ref int y)
        {
            int r = x;
            x = y;
            y = r;
        }
        static void Task1()
        {
            

            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            Console.WriteLine(string.Join(", ", array));

            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            swap(ref array[i1], ref array[i2]);
            Console.WriteLine(string.Join(", ", array));
        }
        static void Task2()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = CalculateSum(numbers);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("Сумма элементов: " + sum);

            int product;
            CalculateProduct(numbers, out product);
            Console.WriteLine("Произвединие чисел: " + product);

            double average;
            CalculateAverage(numbers, out average);
            Console.WriteLine("Средняя арифметика: " + average);
        }

        public static int CalculateSum(params int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static void CalculateProduct(int[] array, out int product)
        {
            product = 1;
            foreach (int num in array)
            {
                product *= num;
            }
        }

        public static void CalculateAverage(int[] array, out double average)
        {
            int sum = CalculateSum(array);
            average = (double)sum / array.Length;
        }
        static void Main()
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}

    

    





