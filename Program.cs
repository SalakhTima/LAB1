using System;

namespace projectname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = 0;
            Console.WriteLine("Введите начало диапазона:");
            int k = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите конец диапазона:");
            int n = int.Parse(Console.ReadLine()); 
            int a = 1;
            Console.WriteLine("\nРезультат:");
            for (int i = 1; i <= n; i++)
            {
                a++;
                for (int z = 2; z <= n; z++)
                {
                    if (a == z) { }
                    else if (a % z != 0) { }
                    
                    else if (a % z == 0) { g++; }
                }
                if (a > k)
                {
                    if (g == 0) { Console.Write("{0} ", a); }
                }
                g = 0;
            }
            Console.ReadLine();
        }
    }
}
