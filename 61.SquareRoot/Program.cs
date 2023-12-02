using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace _61.SquareRoot
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException();
                }

                double sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid format.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        //static void Main()
        //{
        //    try
        //    {
        //        double input = double.Parse(Console.ReadLine());
        //        Console.WriteLine(ReturnSqrt(input));
        //    }
        //    catch (ArgumentOutOfRangeException ex)
        //    {
        //        Console.WriteLine("Invalid number.");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Goodbye.");
        //    }
        //}

        //public static double ReturnSqrt(double inputNumber)
        //{
        //    if (inputNumber < 0)
        //    {
        //        throw new ArgumentOutOfRangeException();
        //    }
        //    return Math.Sqrt(inputNumber);
        //}
    }
}
