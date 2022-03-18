using System;
using System.Globalization;

namespace tarefas
{
    class ex1006
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;       

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (((nota1 * 2 ) + (nota2 * 3) + (nota3 * 5)) / 10);

            Console.WriteLine($"MEDIA = {media.ToString("F1", CI)}");

        }
    }
}