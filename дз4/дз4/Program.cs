using System;
namespace Zadanii
{
    internal class Program
    {
        static int max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Zadanie1()
        {
            int c = max(8, 12);
            Console.WriteLine();
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите первое число: 8");
            Console.WriteLine("Введите второе число: 12");
            Console.WriteLine("Наибольшое число:"+ c);
        }
        static void Zadanie2()
        {
             static void swap(ref int x, ref int y)
            {
                int r = x;
                x = y;
                y = r;
            }

            int x = 20;
            int y = 23;
            swap(ref x, ref y);
            Console.WriteLine();
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine( x + "  " + y);
        }
        static void Zadanie3() 
        {
            static bool calcFactorial(int n, out int p)
            {
                try
                {
                    p = 1;
                    checked
                    {
                        for (int i = 1; i <= n; i++)
                        {
                          p*= i;
                        }
                    }
                    return true;
                }
                catch (OverflowException)
                {
                    p = 0;
                    return false;
                }
            }

            int p;
            bool s = calcFactorial(17, out p);
            Console.WriteLine();
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Введем число: 17 ");
            Console.WriteLine(p);
            Console.WriteLine(s);
        }  
        static void Zadanie4()
        {
            static int factorial(int a)
            {

                if (a != 0)
                    return a * factorial(a - 1);
                else
                    return 1;
            }
            int c = factorial(6);
            Console.WriteLine();
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введем: 6! ");
            Console.WriteLine(c);
        }
        static void Zadanie5()
        {
            static int nod(int a, int b)
            {
                while (b != 0)
                {
                    int r = b;
                    b = a % b;
                    a = r;
                }
                return a;
            }

             static int nod2(int a, int b, int c)
            {
                return nod(nod(a, b), c);
            }
            int p1 = nod(12, 18);
            int p2 = nod2(24, 36, 48);
            Console.WriteLine();
            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("НОД(12,18) = "+ p1);
            Console.WriteLine("НОД(24,36,48) = "+ p2);
        }
        static void Zadanie6()
        {
            static int fibonacci(int n)
            {
                if (n <= 1)
                    return n;
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
            int n = 7;
            int p = fibonacci(n);
            Console.WriteLine();
            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Под номером n(7) стоит число: "+ p);
        }
        static void Main()
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();
            Zadanie5();
            Zadanie6();
            Console.ReadKey();
        }
    }
}










