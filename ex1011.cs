using System;
using System.Globalization;

namespace tarefas
{
    class ex1011
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double raio, res, pi = 3.14159;

            raio = Convert.ToDouble(Console.ReadLine());
            res = (4.0/3.0) * pi * (raio * raio * raio);

            Console.WriteLine($"VOLUME = {res.ToString("F3", CI)}");
        }
    }
}