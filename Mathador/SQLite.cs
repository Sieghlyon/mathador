using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Mathador
{
    public class SQLite
    {
        public static void creer_BDD()
        {
            if (!System.IO.File.Exists("BDD.sqlite"))
            {
                SQLiteConnection.CreateFile("BDD.sqlite");
            }

            SQLiteConnection connexion;
            connexion = new SQLiteConnection("Data Source = BDD.sqlite; Version=3;");
            connexion.Open();         

            string sql = "CREATE TABLE IF NOT EXISTS highscore (pseudo, score, nombre_calcul, temps_moyen, score_moyen, score_min, score_max, addition, soustraction, multiplication, division)";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            commande.ExecuteNonQuery();

            connexion.Close();
        }

        public static void write(string pseudo, int score, int nbr_c, string temps_moyen, double score_moyen, int score_min, int score_max, int addition, int soustraction, int multiplication, int division)
        {
            SQLiteConnection connexion;
            connexion = new SQLiteConnection("Data Source = BDD.sqlite; Version=3;");
            connexion.Open();

            string sql = "INSERT INTO highscore VALUES (@pseudo, @score, @nombre_calcul, @temps_moyen, @score_moyen, @score_min, @score_max, @addition, @soustraction, @multiplication, @division)";

            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            commande.Parameters.AddWithValue("@pseudo", pseudo);
            commande.Parameters.AddWithValue("@score", score);
            commande.Parameters.AddWithValue("@nombre_calcul", nbr_c);
            commande.Parameters.AddWithValue("@temps_moyen", temps_moyen);
            commande.Parameters.AddWithValue("@score_moyen", score_moyen);
            commande.Parameters.AddWithValue("@score_min", score_min);
            commande.Parameters.AddWithValue("@score_max", score_max);
            commande.Parameters.AddWithValue("@addition", addition);
            commande.Parameters.AddWithValue("@soustraction", soustraction);
            commande.Parameters.AddWithValue("@multiplication", multiplication);
            commande.Parameters.AddWithValue("@division", division);

            commande.ExecuteNonQuery();

            connexion.Close();
        }

        public static List<Sqlite_Data> read()
        {
            List<Sqlite_Data> liste_d = new List<Sqlite_Data>();

            SQLiteConnection connexion;
            connexion = new SQLiteConnection("Data Source = BDD.sqlite; Version=3;");
            connexion.Open();

            string sql = "select * from highscore order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, connexion);

            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                liste_d.Add(new Sqlite_Data(reader["pseudo"].ToString(), Convert.ToInt32(reader["score"]), Convert.ToInt32(reader["nombre_calcul"]))) ;
            }
            return liste_d;
        }
    }

    
}
