using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Maze_Gui;

namespace W_Maze_Gui
{

    public partial class appMode : Form
    {
        W_Maze_Gui _gui;

        public appMode(W_Maze_Gui gui)
        {
            _gui = gui;
            InitializeComponent();
        }


        private void trainModeButton_Click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("R");
            _gui.trainMode();
            _gui.train = true;
            Close();
        }

        private void testModeButton_Click(object sender, EventArgs e)
        {
           W_Maze_Gui.sendMessage("T");
            _gui.train = false;
            Close();
        }
    }
}
