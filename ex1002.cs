using System;
using System.Globalization;

namespace tarefas
{
    class ex1002
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double total, pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine());
            total = ((raio * raio) * pi);
            Console.WriteLine($"A={total.ToString("F4", CI)}");

        }
    }
}
            

        
    

