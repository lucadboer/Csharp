using System;
using System.Globalization;

namespace tarefas
{
    class ex1007
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;       

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            double dif = ((a * b) - (c * d));

            Console.WriteLine($"DIFERENCA = {dif}");

        }
    }
}