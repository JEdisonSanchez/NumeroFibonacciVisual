using System;
using System.Collections.Generic;
namespace NumeroFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci objFibonacci = new Fibonacci(7);
            objFibonacci.imprimirSerieFibonacci();
            objFibonacci.imprimirPrimo();

            Console.ReadLine();
        }
    }
}
