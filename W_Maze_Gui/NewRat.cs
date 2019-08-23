using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_Maze_Gui
{
    public partial class NewRat : Form
    {
        public NewRat()
        {
            InitializeComponent();
        }

        private void newRatNo_TextChanged(object sender, EventArgs e)
        {
            W_Maze_Gui.newRatNo = newRatNo.Text;


        }

        private void newRatAge_TextChanged(object sender, EventArgs e)
        {
            W_Maze_Gui.newRatAge = newRatAge.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            W_Maze_Gui.newRatNo = newRatNo.Text;
            W_Maze_Gui.newRatAge = newRatAge.Text;
            this.Close();
        }
    }
}
