using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    public class Sqlite_Data
    {
        public Sqlite_Data(string name, int h_sc , int nbr)
        {
            pseudo = name;
            score = h_sc;
            manche = nbr;
        }
        public string pseudo { get; set; }

        public int score { get; set; }

        public int manche { get; set; }
    }
}
