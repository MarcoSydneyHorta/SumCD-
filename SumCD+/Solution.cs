using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SumCD_
{
    class Solution
    {
        public static void CalPoints(string[] ops, ref List<int> vs, ref bool valid)
        {
            int tam = ops.Length;
            int num;

            for (int i = 0; i < tam; i++)
            {
                switch (ops[i])
                {
                    case "C":   // Remove the last number
                        if (vs.Count > 0)
                        {
                            vs.Remove(vs.Last());
                        }
                        else
                        {
                            Console.WriteLine("Nothing to remove");
                            valid = false;
                        }
                        break;
                    case "D":
                        if (vs.Count > 0)
                        {
                            vs.Add(2 * vs.Last()); // Put 2 * last number
                        }
                        else
                        {
                            Console.WriteLine("Nothing to duplicate");
                            valid = false;
                        }
                        break;
                    case "+":
                        if (vs.Count > 1)
                        {
                            vs.Add(vs.Last() + vs[vs.Count - 2]);   // Put last number + penultimate number
                        }
                        else
                        {
                            Console.WriteLine("Data numbers must be at least 2 numbers");
                            valid = false;
                        }
                        break;
                    default:
                        if (int.TryParse(ops[i], out num))
                        {
                            vs.Add(int.Parse(ops[i]));  // Put the number 
                        }
                        else
                        {
                            Console.WriteLine("Character " + ops[i] + " not apply");
                            valid = false;
                        }
                        break;
                }
            }

        }
    }
}

