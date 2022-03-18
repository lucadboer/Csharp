using System;

namespace tarefas
{
    class ex1001
    {
        static void Main(string[] args)
        {
            string ax = Console.ReadLine();
            string bx = Console.ReadLine();

            Console.WriteLine($"X = {Convert.ToInt32(ax) + Convert.ToInt32(bx)}");
            
        }
    }
}