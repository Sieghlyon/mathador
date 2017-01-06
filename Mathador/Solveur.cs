using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Solveur
    {
        private bool faisable = false;
        private int cible;
        private List<Solution> list_sol;
        
        private int nbr_solution = 0;

        Mechanic calcul;
        public Solveur(int c)
        {
            cible = c;
            calcul = new Mechanic();
            list_sol = new List<Solution>();
        }

        public bool faisabilite                                     
        {
            get { return faisable; }
            set { faisable = value; }
        }

        private void tester(int resultat, int op_g, int op_d, string opera)                                    
        {
            if (resultat == cible)
            {
                faisable = true;
                list_sol.Add(new Solution(op_g, op_d, opera, resultat));
                nbr_solution += 1;
            }
            
        }

        /* fonction recursive de recherche pour tester la faisabilite
         
         */
        public void recherche(int [] tirage, int taille)
        {
            int[] cache = tirage;
            int operande_1, operande_2;
            string[] operat = new string[4] { "+", "-", "*", "/"};

            if (taille > 1)
            {
                for (int i = 0; i < taille - 1; i++) /*Parcours du tableau du jusqu'à l'avant dernière case*/
                {
                    for (int j = i + 1; j < taille; j++)
                    {

                        operande_1 = cache[i];
                        operande_2 = cache[j];

                        foreach(string k in operat)
                        {
                            if (calcul.calcul(operande_1, operande_2, k) != 0)
                            {

                                cache[i] = calcul.calcul(operande_1, operande_2, k);

                                tester(cache[i], operande_1, operande_2, k);

                                cache[j] = cache[taille - 1];
                                recherche(cache, taille - 1);

                                cache[j] = operande_2;
                            }

                            cache[i] = operande_1;

                        }
                    }
                }
            }          
        }

        public void afficher()
        {
            foreach (var i in list_sol)
            {
                i.combinaison();

            }
            Console.WriteLine("nombre de solution =  " + nbr_solution);      
        }

    }
}
