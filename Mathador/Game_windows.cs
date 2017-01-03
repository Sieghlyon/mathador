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
    public partial class Game_windows : UserControl
    {
        private Timer watch = new Timer();   // timer pour le chronometre
        private  Button[] bouton;
        private  Button[] tab_op ;
        private List<string> ope_used;
        private List<Cancel_Data> cancel_array;

        private bool trouver;
        private int time_total = 18000;
        private int[] array_tirage = new int[5] ;       // tirage dans un tableau
        private int valeur_cible ;

        private int score = 0;                  //score du joueur et pseudo
        private string name;
        private int nbr_round = 0;
        private int ind_json = 0;
        private Button pressed = null;

        private int nombre_1 = 0;                         // pour gerer le gameplay
        private int nombre_2 = 0;
        private string operateur = "";
        private int first_val;                           // indice de la premiere operande
        private int val_supp;                            // indice second operande a supprimer après calcul

        Mechanic M = new Mechanic();                     // function separé dans une autre classe pour plus de lisibilite
        public Game_windows(string pseudo)
        {
            InitializeComponent();
            name = pseudo;
            bouton = new Button[5] { number_1, number_2, number_3, number_4, number_5 };
            tab_op = new Button[4] { addition, soustraction, multiplication, division };

            Json_Data data = Sauvegarder.read(ind_json);
            valeur_cible = data.number_cible;
           
            for (int i = 0; i < 5; i++)
            {
                array_tirage[i] = data.tirage[i];
            }
            
            ope_used = new List<string>();

            ind_json += 1;

        }

        protected override void OnLoad(EventArgs e)                    // initialization du timer
        {
            //timer interval
            watch.Interval = 10;  //en milliseconds

            watch.Tick += new EventHandler(t_Tick);

            watch.Start();

            for(int i = 0; i < 5; i++)
            {
                bouton[i].Text  = array_tirage[i].ToString();
            }
            
            cible.Text = valeur_cible.ToString();

            cancel_array = new List<Cancel_Data>();

            base.OnLoad(e);
        }

        private void t_Tick(object sender, EventArgs e)  //affichage du temps
        {
            //temps actuel
            time_total -= 1;
            string time = M.convert_time(time_total);

            //update label
            watcher.Text = time;

             if(time_total <= 0)
            {
                stop();
            }
        }

        private void stop()                                 // fonction pour stopper toute activite a la fin du chrono
        {
            watch.Enabled = false;

            foreach (Button b in bouton)
            {
                b.Enabled = false;
            }
            foreach (Button tab in tab_op)
            {
                tab.Enabled = false;
            }

            suivant.Enabled = false;
            annuler.Enabled = false;

            SQLite.creer_BDD();
            SQLite.write(name, score, nbr_round);

        }

        private void E_verification()              //verifie si l'on a trouver la valeur
        {
            trouver = M.check_valeur(array_tirage, valeur_cible);
            if (trouver == true)
            {
                suivant.Text = "Suivant";
            }
            else
            {
                suivant.Text = "Passer";
            }
        }

        private void next_turn()                                 // créér le prochain tour de jeu
        {
            Json_Data data = Sauvegarder.read(ind_json);
            valeur_cible = data.number_cible;
            cible.Text = valeur_cible.ToString();

            for(int i = 0; i < 5; i++)
            {
                array_tirage[i] = data.tirage[i];
                bouton[i].Text = array_tirage[i].ToString();
            }

            ind_json += 1;
            cancel_array.Clear();

            nombre_1 = 0;
            nombre_2 = 0;
            operateur = "";

            decolor();
            pressed = null;

        }

        private void affichage(int indice, int valeur)                       // gestion de l'affichage des valeurs sur les boutons
        {
            int supp = val_supp;
            for(int i = 0; i < 5; i++)
            {
                if (i == indice)
                {
                    bouton[i].Text = valeur.ToString();
                    array_tirage[i] = valeur;
                }
                if (i == supp)
                {
                    bouton[i].Text = "";
                    array_tirage[i] = 0;
                    bouton[i].Enabled = false;
                }
            }
        }

        private void select_elem(int indic, bool coche)
        {  
            foreach(Button b in bouton)
            {
                b.BackColor = SystemColors.Control;
                if (bouton[indic].BackColor == SystemColors.Control && coche == false && bouton[indic].Text != "")
                {
                    bouton[indic].BackColor = SystemColors.Highlight;
                }        
            }
        }

        // les 2 fonction gerent la colorisation pour savoir ce qu'on a selectionner

        private void color_op(int oper, bool coche)
        {
            foreach (Button tab in tab_op)
            {
                tab.BackColor = SystemColors.Control;
                if (tab_op[oper].BackColor == SystemColors.Control && coche == false)
                {
                    tab_op[oper].BackColor = SystemColors.Highlight;
                }
            }
        }

        private void decolor()
        {
            foreach (Button b in bouton)
            {
                b.BackColor = SystemColors.Control;               
            }
            foreach (Button tab in tab_op)
            {
                tab.BackColor = SystemColors.Control;
            }
        }

        private void calculer()                            // calcul des valeurs si possible
        {
            int calculer = M.calcul(nombre_1, nombre_2, operateur);

            if (M.calcul(nombre_1, nombre_2, operateur) != 0)
            {
                affichage(first_val, calculer);               
                E_verification();
                ope_used.Add(operateur);
                cancel_array.Add(new Cancel_Data(nombre_1, nombre_2, first_val, val_supp));
            }

            nombre_1 = 0;
            nombre_2 = 0;
            operateur = "";

            decolor();
        }

        private void gestion_bouton(int ind, string op, Button b)             // fonction de gestion des boutons
        {
            if (b == pressed && nombre_2 == 0 && op == "null")                 // recliquer sur le meme nombre le decoche
            {
                select_elem(ind, true);
                nombre_1 = 0;
                pressed = null;
            }
            else if (nombre_1 != 0 && operateur != "" && op == "null")
            {
                nombre_2 = array_tirage[ind];
                val_supp = ind;
                select_elem(ind, false);
            }
            else if (operateur == op)
            {
                operateur = "";
                color_op(ind, true);
            }
            else if (operateur != op && op != "null")
            {
                operateur = op;
                color_op(ind, false);
            }
            else
            {
                first_val = ind;
                nombre_1 = array_tirage[ind];
                select_elem(ind, false);
                pressed = b;
            }
            if (nombre_1 != 0 && nombre_2 != 0 && operateur != "")
            {
                calculer();
            }
                   
        }

        private void cancel()
        {
            Cancel_Data c_data = cancel_array[cancel_array.Count - 1];
            array_tirage[c_data.position_n1] = c_data.number_1;
            array_tirage[c_data.position_n2] = c_data.number_2;
            bouton[c_data.position_n1].Text = array_tirage[c_data.position_n1].ToString();
            bouton[c_data.position_n2].Text = array_tirage[c_data.position_n2].ToString();
            bouton[c_data.position_n1].Enabled = true;
            bouton[c_data.position_n2].Enabled = true;
            cancel_array.Remove(cancel_array.Last());
        }

        private void addition_Click(object sender, EventArgs e)
        {
            gestion_bouton(0, "+", addition);
        }

        private void soustraction_Click(object sender, EventArgs e)
        {
            gestion_bouton(1, "-", soustraction);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            gestion_bouton(2, "*", multiplication);
        }

        private void division_Click(object sender, EventArgs e)
        {
            gestion_bouton(3, "/", division);
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            gestion_bouton(0 , "null", number_1);
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            gestion_bouton(1, "null", number_2);
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            gestion_bouton(2, "null", number_3);
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            gestion_bouton(3, "null", number_4);
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            gestion_bouton(4, "null", number_5);
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            if (suivant.Text == "Suivant")
            {
                score += M.calcul_score(ope_used);
                score_player.Text = score.ToString();
                next_turn();
                nbr_round += 1;
            }
            else
            {
                next_turn();   
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            if (cancel_array.Count != 0)
            {
                cancel();
            }
        }
    }
}
