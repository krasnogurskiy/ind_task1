using System;

namespace ind_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17 option.");
            Task_1();
            Task_2();
            Task_3();
        }

        /*
         Задача 1. Дано натуральне число n. Перевести його до двійкової системи числення.
         */
        

        static void Task_1()
        {
            Console.WriteLine("Task 1.");
            Console.Write("Enter a number: ");
            uint number = uint.Parse(Console.ReadLine());
            string bin = "";
            uint num = number;

            while (number != 0)
            {
                uint bit = number % 2;
                bin = bit + bin;
                number /= 2;
            }

            Console.WriteLine($"Number {num} in binary - {bin}");
        }

        /*
          Задача 2. Дано x,y,z. Обчислити max(a, b, c), якщо:
          a = 2*sqrt(x^2 + y^2) - (z^3 / 3!) ; 
          b = 1 - sqrt(x^2 + y^2);
          c = sin(z^3 / 3!) + cos(pi/4). 
        */
        static void Task_2()
        {
            Console.WriteLine("Task 2. ");
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            double z = double.Parse(Console.ReadLine());

            double a = 2 * Math.Sqrt(x * x + y * y) - (z * z * z / 6);
            double b = 1 - Math.Sqrt(x * x + y * y);
            double c = Math.Sin(z * z * z / 6) + Math.Cos(Math.PI / 4);

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            // the first way to calculate the maximum number
            double maxV = a;
            if (b > maxV)
            {
                maxV = b;
            }
            if (c > maxV)
            {
                maxV = c;
            }

            /* 
            //The second way to calculate the maximum number 
             
            double maxV = Math.Max(a, Math.Max(b, c));

            // The third way to calculate the maximum number 

            double maxV = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c)

            // The forth way to calculate the maximum number

            double[] values = { a, b, c };
            double maxV = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                maxV = Math.Max(maxV, values[i]);
            }
            
            */

            Console.WriteLine($"Maximum value is {maxV}");
        }

        /* 
            Задача 3. Дано матрицю А:5х6. Утворити і надрукувати вектор b,
            елементами якого є максимальні елементи рядків матриці А.
            Знайти номер мінімального елемента вектора b.
        */
        static void Task_3()
        {
            Console.WriteLine("Task 3. ");

            int[,] A = new int[5, 6] {
                {1, 2, 3, 4, 5, 66 },
                {1, 4, 9, 16, 25, 36 },
                {2, 4, 6, 8, 10, 12 },
                {7, 5, 9, 68, 11, 14 },
                {1, 11, 21, 31, 41, 51 }
            };

            int[] b = new int[A.GetLength(0)];

            for (int i = 0; i < A.GetLength(0); i++)    // find the max element of each row of A;
            {
                int maxElem = A[i, 0];
                for (int j = 1; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > maxElem)
                    {
                        maxElem = A[i, j];
                    }
                }
                b[i] = maxElem;
            }

            Console.Write("Vector b: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();

           
            int minIndex = 0;                   // find the index of the min element of b;
            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] < b[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"Index of minimum element of vector b: {minIndex}");
        }
    }
}
