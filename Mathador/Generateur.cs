using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Generateur
    {
        private Random rnd = new Random();
        private Solveur solve;
        private int[] tab;
        public void generer()
        {
            int number_1 = rnd.Next(1, 13);
            int number_2 = rnd.Next(1, 13);
            int number_3 = rnd.Next(1, 13);

            int number_4 = rnd.Next(1, 21);
            int number_5 = rnd.Next(1, 21);

            int number_cible = rnd.Next(1, 101);

            tab = new int[5]{ number_1, number_2, number_3, number_4, number_5};

            solve = new Solveur(number_cible);
            solve.recherche(tab, 5);

            if (solve.faisabilite == true)
            {
                Sauvegarder.sauve(number_1, number_2, number_3, number_4, number_5, number_cible);
            }

            solve.afficher();
        }     
    }
}
