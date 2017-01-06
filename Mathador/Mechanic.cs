using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Mechanic
    {
        public int calcul(int n_1, int n_2, string op)
        {
            if (op == "+")
            {
                return (n_1 + n_2);
            }
            else if (op == "-" && n_1 - n_2 > 0)
            {
                return (n_1 - n_2);
            }
            else if (op == "*")
            {
                return (n_1 * n_2);
            }
            else if (op == "/" && n_1 % n_2 == 0)
            {
                return (n_1 / n_2);
            }
            else
            {                
                return 0;
            }
            
        }
       
        public int calcul_score(List<string> op)
        {
            int score_round = 0;
            bool add = false;
            bool sous = false;
            bool mul = false;
            bool div = false;

            foreach (string i in op)
            {
                if (i == "+")
                {
                    score_round += 1;
                    add = true;
                }
                if (i == "-")
                {
                    score_round += 2;
                    sous = true;
                }
                if (i == "*")
                {
                    score_round += 1;
                    mul = true;
                }
                if (i == "/")
                {
                    score_round += 3;
                    div = true;
                }
            }
            if (add == true && sous == true && mul == true && div == true )
            {
                score_round = 13;
            }
            return score_round;
        }

        public bool check_valeur(int[] array, int cible)
        {
            foreach (int i in array)
            {
                if (i == cible)
                {                    
                    return true;
                }
            }
            return false;
        }

        public string convert_time(int time_total)
        {
            int minute = 0;
            int seconde = 0;
            int milliseconde = time_total;

            if (milliseconde > 59)
            {
                minute = time_total / 6000;
                seconde = (time_total % 6000) / 100;
                milliseconde = (time_total % 6000) % 100;
            }
            if (seconde > 59)
            {
                minute += seconde / 60;
                seconde += seconde % 60;
            }

            //time
            string time = "";

            time += minute;

            time += ":";

            if (seconde < 10)
            {
                time += "0" + seconde;
            }
            else
            {
                time += seconde;
            }
            time += ":";

            if (milliseconde < 10)
            {
                time += "0" + milliseconde;
            }
            else
            {
                time += milliseconde;
            }
            return time;
        }
    }

    public class Cancel_Data
    {
        public Cancel_Data(int n_1, int n_2, int pos_1, int pos_2)
        {
            number_1 = n_1;
            number_2 = n_2;
            position_n1 = pos_1;
            position_n2 = pos_2;
        }
        public int number_1 { get; set; }

        public int number_2 { get; set; }

        public int position_n1 { get; set; }

        public int position_n2 { get; set; }
    }
}
