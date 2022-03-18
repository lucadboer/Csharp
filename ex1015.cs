using System;
using System.Globalization;

namespace tarefas
{
    class ex1015
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;    
            String line1 =  Console.ReadLine();
            String line2 =  Console.ReadLine();

            String[] values1 = line1.Split(' ');
            float x1 = float.Parse(values1[0]);
            float y1 = float.Parse(values1[1]);

            String[] values2 = line2.Split(' ');
            float x2 = float.Parse(values2[0]);
            float y2 = float.Parse(values2[1]);

            double res = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))); 
            Console.WriteLine($"{res.ToString("F4", CI)}");
        }
    }
}