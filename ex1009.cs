using System;
using System.Globalization;

namespace tarefas
{
    class ex1009
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;       

            string nome = Console.ReadLine();
            double salario = Convert.ToDouble(Console.ReadLine());
            double bonus = Convert.ToDouble(Console.ReadLine());

            double salarioBonus = salario + (bonus * 0.15);

            Console.WriteLine($"TOTAL = R$ {salarioBonus.ToString("F2", CI)}");


        }
    }
}