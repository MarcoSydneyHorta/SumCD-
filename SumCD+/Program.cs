using System;
using System.Collections.Generic;

namespace SumCD_
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            string[] dados;
            List<int> vs = new List<int>();
            
            Console.Write("Digite os dados separados por espaço: ");
            entrada = Console.ReadLine();
            dados = entrada.Split(" ");

            int total = 0;
            Solution.CalPoints(dados, ref vs);

            Console.Write("The total sum is = ");
            for (int i = 0; i < vs.Count; i++)
            {
                if (i == vs.Count - 1)
                {
                    Console.Write(vs[i] + " = " + (vs[i] + total));
                }
                else
                {
                    Console.Write(vs[i] + " + ");
                }
                total += vs[i];
            }
            Console.Read();
        }
    }
}
