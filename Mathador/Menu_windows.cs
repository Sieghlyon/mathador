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
    public partial class Menu_windows : UserControl
    {
        Score_windows score;
        Game_windows game;
        public Menu_windows()
        {
            InitializeComponent();
        }

        private void to_score_Click(object sender, EventArgs e)
        {
            score = new Score_windows();
            Controls.Clear();
            Controls.Add(score);
        }

        private void to_game_Click(object sender, EventArgs e)
        {
            if (pseudo.Text != "")
            {
                game = new Game_windows(pseudo.Text);
                Controls.Clear();
                Controls.Add(game);
            }
            
        }
    }
}
