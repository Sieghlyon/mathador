using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mathador
{
    public partial class Score_windows : UserControl
    {
        Menu_windows menu;
        private SQLiteConnection connexion;

        public Score_windows()
        {
            InitializeComponent();
            show_score();
        }

        private void show_score()
        {
            SQLite.creer_BDD();
            connexion = new SQLiteConnection("Data Source = BDD.sqlite; Version=3;");
            DataSet dataSet = new DataSet();
            string sql = "select * from highscore order by score desc";

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, connexion);
            dataAdapter.Fill(dataSet);

            Score_Grid.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void to_menu_Click(object sender, EventArgs e)
        {
            menu = new Menu_windows();
            Controls.Clear();
            Controls.Add(menu);       
        }
    }
}
