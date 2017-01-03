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

        Mechanic calcul;
        public Solveur(int c)
        {
            cible = c;
            calcul = new Mechanic();
        }

        public bool faisabilite                                     
        {
            get { return faisable; }
            set { faisable = value; }
        }

        private void tester(int resultat)                                    
        {
            if (resultat == cible)
            {
                faisable = true;
                
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
                                tester(cache[i]);

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
    }
}
