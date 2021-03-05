using System;

namespace Project
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            WorkingWithArray myArray = new WorkingWithArray();

            _ = myArray.SetNumberOfArrayLines();
            _ = myArray.SetNumberOfArrayColumns();
            _ = myArray.CreateArray();
            myArray.OutputArray();
            myArray.FindArrayValue();
        again:
            Console.WriteLine("\nEnter – обрати інший елемент\nБудь–яка інша клавіша"
                + " – обчислити мінімальне значення в кожному рядку масиву та його індекс");

            // Зміни_1
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                myArray.FindArrayValue();
                goto again;
            }
            else
            {
                Console.WriteLine();
                myArray.FindMinimumArrayValue();
            }
        }
    }
}