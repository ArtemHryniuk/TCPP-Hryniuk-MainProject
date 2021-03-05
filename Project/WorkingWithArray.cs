using System;

namespace Project
{
    public class WorkingWithArray
    {
        public WorkingWithArray() { }

        public int M { get; set; }
        public int N { get; set; }
        public int[,] Array { get; set; }

        public int SetNumberOfArrayLines()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введіть кількість рядків масиву: ");
                    M = Convert.ToInt32(Console.ReadLine());
                    if (M <= 0)
                    {
                        Console.WriteLine("Введіть додатнє число та більше нуля!\nСпробуйте ще раз\n");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введіть число!\nСпробуйте ще раз\n");
                }
            }
            return M;
        }

        // Зміни_2
        public int SetNumberOfArrayColumns()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введіть кількість стовпчиків масиву: ");
                    N = Convert.ToInt32(Console.ReadLine());
                    if (N <= 0)
                    {
                        Console.WriteLine("Введіть додатнє число та більше нуля!\nСпробуйте ще раз\n");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введіть число!\nСпробуйте ще раз\n");
                }
            }
            return N;
        }

        public int[,] CreateArray()
        {
            Console.WriteLine($"Двовимірний цілочисельний масив розміром {M} x {N}:");
            Array = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Array[i, j] = new Random().Next(1, 40);
                }
            }
            return Array;
        }

        public void OutputArray()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{Array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public void FindArrayValue()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введіть елемент, який потрібно знайти: ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    int count = 0;
                    for (int i = 0; i < M; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            if (element == Array[i, j])
                            {
                                Console.WriteLine($"Елемент масиву {element} знаходиться на позиції – {i}, {j}");
                                count++;
                            }
                        }
                    }
                    Console.WriteLine($"Кількість повторень: {count}");
                    if (count == 0)
                    {
                        Console.WriteLine($"Елементу {element} у масиві немає");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введіть число!\nСпробуйте ще раз\n");
                }
            }
        }

        public void FindMinimumArrayValue()
        {
            for (int i = 0; i <= Array.GetUpperBound(0); i++)
            {
                double min = double.MaxValue;
                int indexI = 0, indexJ = 0;
                for (int j = 0; j <= Array.GetUpperBound(1); j++)
                {
                    if (min > Array[i, j])
                    {
                        min = Array[i, j];
                        indexI = i;
                        indexJ = j;
                    }
                }
                Console.WriteLine("Мінімальне значення – {0}, індекс – {1},{2}", min, indexI, indexJ);
            }
        }
    }
}