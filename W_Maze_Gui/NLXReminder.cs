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
        public NLXReminder()
        {
            InitializeComponent();
        }

        private void confirm(object sender, EventArgs e)
        {
            Close();
        }

        private void notRecording(object sender, EventArgs e)
        {
            Close();
            W_Maze_Gui.recordButton.Enabled = false;
            W_Maze_Gui.acquireButton.Enabled = false;
        }
    }
}
