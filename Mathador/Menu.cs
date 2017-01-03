using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathador
{
    public partial class Menu : Form
    {
        Score_windows score;
        Game_windows game;
        Menu_windows menu;
        public Menu()
        {
            
            InitializeComponent();
            score = new Score_windows();
            game = new Game_windows("");
            menu = new Menu_windows();
            Controls.Add(menu);
        }
     
        
    }
}
