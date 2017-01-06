using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathador
{
    public partial class Resultat : UserControl
    {
        private int score_max, score_min;
        private double score_moyenne, temps_moyenne;
        private int add, sous, mul, div;
        private string time;

        private Menu_windows menu;
        private Score_windows score;
        private Mechanic M = new Mechanic();

        private void to_score_Click(object sender, EventArgs e)
        {
            score = new Score_windows();
            Controls.Clear();
            Controls.Add(score);
        }

        private void to_menu_Click(object sender, EventArgs e)
        {
            menu = new Menu_windows();
            Controls.Clear();
            Controls.Add(menu);
        }

        public Resultat(int score, string name, int nbr_round, List<int> temps_moyen, List<int> score_moyen, List<string> ope_moyen)
        {
            InitializeComponent();

            statistique(score_moyen, temps_moyen);
            stat_operateur(ope_moyen);
            affichage(name);

            sauve_resultat(score, name, nbr_round);
           
        }

        private void affichage(string pseudo)
        {
            label12.Text = pseudo;
            label11.Text = temps_moyenne.ToString();

            label7.Text = score_min.ToString();
            label8.Text = score_moyenne.ToString();
            label9.Text = score_max.ToString();
        }

        private void sauve_resultat(int score, string name, int nbr_round)
        {
            SQLite.creer_BDD();

            SQLite.write(name, score, nbr_round, time, score_moyenne, score_min, score_max, add, sous, mul, div);
        }

        private void statistique(List<int> score_m , List<int> temps_m)
        {          
            if(score_m.Count() == 0)
            {
                score_max = 0;
                score_min = 0;
                score_moyenne = 0;
            }
            else
            {
                score_max = score_m.Max();
                score_min = score_m.Min();
                score_moyenne = score_m.Sum() / score_m.Count();
            }

            if (temps_m.Count() == 0)
            {
                temps_moyenne = 0;
            }
            else
            {
                temps_moyenne = temps_m.Sum() / temps_m.Count();
            }time = M.convert_time(Convert.ToInt32(temps_moyenne));
        }

        private void stat_operateur(List<string> operateur)
        {
            int count_add = ((from temp in operateur where temp.Equals("+") select temp).Count());
            int count_sous = ((from temp in operateur where temp.Equals("-") select temp).Count());
            int count_mul = ((from temp in operateur where temp.Equals("*") select temp).Count());
            int count_div = ((from temp in operateur where temp.Equals("/") select temp).Count());

            int count = operateur.Count();

            if (count_add != 0)
            {
                add = count_add * 100 / count ;
            }
            else { add = 0; }
            if (count_sous != 0)
            {
                sous = count_sous * 100 / count;
            }
            else { sous = 0; }
            if (count_mul != 0)
            {
                mul = count_mul * 100 / count;
            }
            else { mul = 0; }
            if (count_div != 0)
            {
                div = count_div * 100 / count;
            }
            else { div = 0; }

            label1.Text = add.ToString();
            label2.Text = sous.ToString();
            label3.Text = mul.ToString();
            label4.Text = div.ToString();
        }
    }
}
