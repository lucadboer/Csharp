using System;
using System.Globalization;

namespace tarefas
{
    class ex1012
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            String line1 = Console.ReadLine();
            String[] values = line1.Split(' ');
            double A = Convert.ToDouble(values[0]);
            double B = Convert.ToDouble(values[1]);
            double C = Convert.ToDouble(values[2]);

            double triangulo = (A * C) / 2; 
            double circulo = 3.14159 * (C * C);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CI)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CI)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CI)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CI)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CI)}");

        }
    }
}