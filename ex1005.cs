using System;
using System.Globalization;

namespace tarefas
{
    class ex1005
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;       

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double media = (((nota1 * 3.5)  + (nota2 * 7.5)) / 11);

            Console.WriteLine($"MEDIA = {media.ToString("F5", CI)}");

        }
    }
}