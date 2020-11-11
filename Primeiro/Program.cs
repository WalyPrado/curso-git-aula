using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("Segue desconto:");
            Console.WriteLine(desconto);

        }

    }
}
