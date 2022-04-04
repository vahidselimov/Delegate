using System;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 12.1, 23.2, 34.3, 89.2, 21, 23, 45, 34.43,234.323};
        
            Action<double[]> action = Product;
              {
                action(arr);
              };
        }
       public static void Product(double[] arr)
        {
            int product = arr.Length;
           double total = default(int);
            foreach (double number in arr)
            {
                total += number;
            }
            Console.WriteLine($"Total:{total} Product:{product}");
        }
    }
}
