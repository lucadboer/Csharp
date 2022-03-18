using System;
using System.Globalization;

namespace tarefas
{
    class ex1014
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int dist = Convert.ToInt32(Console.ReadLine());
            double litros = Convert.ToDouble(Console.ReadLine());

            double res = dist / litros;

            Console.WriteLine($"{res.ToString("F3", CI)} km/l");
        }
    }
}