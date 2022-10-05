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
            bool valid = true;

            Console.Write("Digite os dados separados por espaço: ");
            entrada = Console.ReadLine();
            dados = entrada.Split(" ");

            int tam = entrada.Length;
            if (tam > 1 || tam <= 1000)
            {

                int total = 0;
                Solution.CalPoints(dados, ref vs, ref valid);
                if (valid == true)
                {

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
                }
                
            }
            else
            {
                Console.WriteLine("Data numbers must be between 1 and 1000 ");
            }
            Console.Read();
        }

     }

}



