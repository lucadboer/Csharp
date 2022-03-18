using System;
using System.Globalization;

namespace tarefas
{
    class ex1008
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;       

            int cod = Convert.ToInt32(Console.ReadLine());
            int horas = Convert.ToInt32(Console.ReadLine());
            double salario = Convert.ToDouble(Console.ReadLine());

            double salarioTotal = horas * salario;

            Console.WriteLine($"NUMBER = {cod}");
            Console.WriteLine($"SALARY = U$ {salarioTotal.ToString("F2", CI)}");


        }
    }
}