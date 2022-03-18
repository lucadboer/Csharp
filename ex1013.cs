using System;
using System.Globalization;

namespace tarefas
{
    class ex1013
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;  
            String line1 = Console.ReadLine();
            String[] values = line1.Split(' ');

            int A = Int32.Parse(values[0]);
            int B = Int32.Parse(values[1]);
            int C = Int32.Parse(values[2]);

            double maiorAB = (A + B + Math.Abs(A - B)) / 2;

            if (maiorAB > C)
            {
                Console.WriteLine($"{maiorAB} eh o maior");
            }
            else
            {
                Console.WriteLine($"{C} eh o maior");
            }

        }
    }
}