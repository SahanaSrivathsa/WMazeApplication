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
    public partial class NLXReminder : Form
    {
        private W_Maze_Gui _gui;

        public NLXReminder(W_Maze_Gui gui)
        {
            _gui = gui;
            InitializeComponent();
        }

        private void confirm(object sender, EventArgs e)
        {
            Close();
        }

        private void notRecording(object sender, EventArgs e)
        {
            Close();
            _gui.disable_NLX();
                
        }
    }
}
