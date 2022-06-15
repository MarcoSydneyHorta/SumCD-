using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SumCD_
{
    class Solution
    {
        public static  void CalPoints(string[] ops, ref List<int> vs)
        {
            int tam = ops.Length;

            for (int i = 0; i < tam; i++)
            {
                switch (ops[i])
                {
                    case "C":   // Remove the last number
                        vs.Remove(vs.Last());
                        break;
                    case "D":
                        vs.Add(2 * vs.Last()); // Put 2*last number
                        break;
                    case "+":
                        vs.Add(vs.Last() + vs.Skip(vs.Count() - 2).First());    // Put last number + penultimate number
                        break;
                    default:
                        vs.Add(int.Parse(ops[i]));  // Put the number 
                        break;
                }
            }

        }
    }
}

