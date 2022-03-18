using System;

namespace tarefas
{
    class ex1020
    {
        static void Main(string[] args)
        { 
            int anos, meses, days;
            string life = Console.ReadLine();
            int dias = Convert.ToInt32(life);

            anos =  dias / 365;
            meses = (dias % 365) / 30;
            days = (dias % 365) % 30;

            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{days} dia(s)"); 
        }
    }
}