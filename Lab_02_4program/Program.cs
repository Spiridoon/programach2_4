using System;

namespace Lab_02_4program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Write x: ");
                float x = Single.Parse(Console.ReadLine());
                Console.Write("Write number of terms Q: ");
                float q = Single.Parse(Console.ReadLine());
                double cos_x = 0.0;
                int degree_x_and_factorial = 0;
                double factorial = 1.0;
                uint metre_of_terms = UInt32.MinValue;
                double term = 0.0;
                for (int i = 0; true; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = degree_x_and_factorial; j > 1; j--)
                        {
                            factorial *= j;
                        }
                        term = Math.Pow(x, degree_x_and_factorial) / factorial;
                        cos_x += term;
                        degree_x_and_factorial += 2;
                        factorial = 1.0;
                    }
                    else
                    {
                        for (int j = degree_x_and_factorial; j > 0; j--)
                        {
                            factorial *= j;
                        }
                        term = Math.Pow(x, degree_x_and_factorial) / factorial;
                        cos_x -= term;
                        degree_x_and_factorial += 2;
                        factorial = 1.0;
                    }
                    if (Math.Abs(term) > q)
                    {
                        metre_of_terms++;
                    }
                    else 
                    {
                        Console.Write($"Number of successful terms: {metre_of_terms}");
                        break;
                    } 
                }
                Console.WriteLine($"\nCos(x) = {cos_x}");
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
