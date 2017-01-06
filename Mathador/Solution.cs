using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Solution
    {
        public Solution(int op_g, int op_d, string opera, int value)
        {
            operande_g = op_g;
            operande_d = op_d;
            operat = opera;
            result = value;
        }
        public int operande_g { get; set; }

        public int operande_d { get; set; }

        public string operat { get; set; }

        public int result { get; set; }

        public void combinaison()
        {
            Console.WriteLine(operande_g + "  " + operat + "  " + operande_d + "  =  " + result);
        }
    }
}
