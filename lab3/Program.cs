//namespace lab3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                int k, s = 0;
//                Console.WriteLine("M: ");
//                var m = int.Parse(Console.ReadLine());

//                for (int i = 0; i < m; i++)
//                {

//                    if (GCD(i,m) - 1 == 0)
//                    {
//                        continue;
//                    }

//                    Console.WriteLine($"При(делитель) {i}");
//                    s = 0;


//                    Console.WriteLine("Аннуляторы перебору: ");
//                    for (int j = 1; j < m; j++)
//                    {
//                        k = (i * j) % m;

//                        if (k == 0)
//                        {
//                            Console.Write($"{j}, ");
//                            s++;
//                        }
//                    }

//                    Console.WriteLine("\nАннуляторы по формуле");
//                    for (int j = 1; j < GCD(i,m); j++)
//                    {
//                        k = (j * m) / GCD(i,m);
//                        Console.Write($"{k}, ");
//                    }

//                    Console.WriteLine($"\nКоличество аннуляторов через перебор: {s} \nКоличество аннуляторов по формуле:{GCD(i,m) - 1}\n");
//                }
//                    Console.ReadKey();
//                    Console.Clear();
//            }
//        }

//        static int GCD(int a, int b)
//        {
//            while (b != 0)
//            {
//                int temp = b;
//                b = a%b; 
//                a = temp;
//            }
//            return a;
//        }
//    }
//}

using System;
using System.Collections.Generic;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {


            //lab4();
            //lab5();
            //lab6();
            //lab7();
        }
        static void lab4()
        {
            while (true)
            {
                Console.Write("Введите значение m: ");
                int m = int.Parse(Console.ReadLine());

                HashSet<int> units = new HashSet<int>();
                HashSet<int> zeroDivisors = new HashSet<int>();

                if (IsZeroDivisor(0, 0, m))
                {
                    zeroDivisors.Add(0);
                }

                for (int i = 1; i < m; i++)
                {
                    if (IsUnit(i, m))
                    {
                        units.Add(i);
                    }
                    
                }

                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < m; j++)
                    {
                        if (IsZeroDivisor(i,j, m))
                        {
                            zeroDivisors.Add(i);
                        }

                    }
                }

                Console.Write("Обратимые элементы: ");
                foreach (int unit in units)
                {
                    Console.Write(unit + " ");
                }

                Console.WriteLine();

                Console.Write("Делители нуля: ");
                foreach (int zeroDivisor in zeroDivisors)
                {
                    Console.Write(zeroDivisor + " ");
                }

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void lab5()
        {
            while (true)
            {
                Console.Write("Введите значение m: ");
                int m = int.Parse(Console.ReadLine());

                if (!IsPrime(m))
                {
                    Console.WriteLine("p должно быть простым числом.");
                    continue;
                }

                HashSet<int> units = new HashSet<int>();
                HashSet<int> zeroDivisors = new HashSet<int>();

                if (IsZeroDivisor(0,0, m))
                {
                    zeroDivisors.Add(0);
                }
                for (int i = 1; i < m; i++)
                {
                    if (IsUnit(i, m))
                    {
                        units.Add(i);
                    }
                }

                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < m; j++)
                    {
                        if (IsZeroDivisor(i, j, m))
                        {
                            zeroDivisors.Add(i);
                        }

                    }
                }

                Console.Write("Обратимые элементы: ");
                foreach (int unit in units)
                {
                    Console.Write(unit + " ");
                }

                Console.WriteLine();

                Console.Write("Делители нуля: ");
                foreach (int zeroDivisor in zeroDivisors)
                {
                    Console.Write(zeroDivisor + " ");
                }

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void lab6()
        {
            while (true)
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"НОД [{num1}, {num2}] = {GCD(num1, num2)}.");

                Console.ReadKey();
                Console.Clear();
            }
        }
        static void lab7()
        {
            while (true)
            {
                Console.Write("Введите значение m: ");
                int m = int.Parse(Console.ReadLine());

                List<int> units = new List<int>();
                List<int> zeroDivisors = new List<int>();
                List<int> NODs = new List<int>();

                //units
                for (int i = 1; i < m; i++)
                {
                    

                    if (IsUnit(i, m) && GCD(i, m) == 1)
                    {
                        units.Add(i);
                    }
                }

                //zeroDivision
                if (IsZeroDivisor(0,0, m))
                {
                    zeroDivisors.Add(0);
                }
                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < m; j++)
                    {
                        if (IsZeroDivisor(i, j, m))
                        {
                            zeroDivisors.Add(i);
                        }
                    }
                }

                Console.WriteLine("<-- Обратимые элементы -->");
                foreach(var item in units)
                {
                    Console.WriteLine($"Обратимый элемент {item} - НОД[{item}, m] = {GCD(item, m)} == 1");
                }
                Console.WriteLine("<-- ----------------- -->\n");

                Console.WriteLine("<-- Делители нуля -->");
                foreach (var item in zeroDivisors.Distinct())
                {
                    Console.WriteLine($"Делитель нуля {item} - НОД[{item}, m] = {GCD(item, m)} > 0");
                }
                Console.WriteLine("<-- ------------- -->");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void lab8()
        {
            while (true)
            {
                Console.Write("Введите значение m: ");
                int m = int.Parse(Console.ReadLine());

                List<int> units = new List<int>();
                List<int> zeroDivisors = new List<int>();
                List<int> NODs = new List<int>();

                //units
                for (int i = 1; i < m; i++)
                {


                    if (IsUnit(i, m) && GCD(i, m) == 1)
                    {
                        units.Add(i);
                    }
                }

                //zeroDivision
                if (IsZeroDivisor(0, 0, m))
                {
                    zeroDivisors.Add(0);
                }
                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < m; j++)
                    {
                        if (IsZeroDivisor(i, j, m))
                        {
                            zeroDivisors.Add(i);
                        }
                    }
                }

                Console.WriteLine("<-- Обратимые элементы -->");
                foreach (var item in units)
                {
                    Console.WriteLine($"Обратимый элемент {item} - НОД[{item}, m] = {GCD(item, m)} == 1");
                }
                Console.WriteLine("<-- ----------------- -->\n");

                Console.WriteLine("<-- Делители нуля -->");
                foreach (var item in zeroDivisors.Distinct())
                {
                    Console.WriteLine($"Делитель нуля {item} - НОД[{item}, m] = {GCD(item, m)} > 0");
                }
                Console.WriteLine("<-- ------------- -->");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }


        #region DopFunc

        // Функция для определения является ли число a обратимым элементом в Zm
        static bool IsUnit(int a, int m)
        {
            int x = a % m;
            int y = m % a;
            int gcd = 0;

            while (y != 0)
            {
                gcd = x % y;
                x = y;
                y = gcd;
            }

            return x == 1;
        }
        // Функция для определения является ли число a делителем нуля в Zm
        static bool IsZeroDivisor(int a, int b, int m)
        {
            return (a * b) % m == 0;
        }
        // НОД по алгоритму евклида
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }
        // проверка на простое число
        static bool IsPrime(int p)
        {
            if (p < 2)
                return false;

            for (int i = 2; i * i <= p; i++)
            {
                if (p % i == 0)
                    return false;
            }

            return true;
        }
        #endregion
    }
}