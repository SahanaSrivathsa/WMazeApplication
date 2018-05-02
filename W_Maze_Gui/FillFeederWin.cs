using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace W_Maze_Gui
{
    public partial class FillFeederWin : Form
    {
        

        public FillFeederWin()
        {
            InitializeComponent();
        }

        public void timeToClean()
        {
            formTitle.Text = "Clean Feeders";
            doneButton.Text = "Done Cleaning";
            fill1.Text = "Clean 1";
            fill2.Text = "Clean 2";
            fill3.Text = "Clean 3";
        }

        private void fill1_click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("1");
            fill1.Hide();
        }

        private void fill2_click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("2");
            fill2.Hide();
        }

        private void fill3_click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("3");
            fill3.Hide();
        }

        private void close1_click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("11");
            fill1.Show();
        }

        private void close2_click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("22");
            fill2.Show();
        }

        private void close3_click(object sender, EventArgs e)
        {
            W_Maze_Gui.sendMessage("33");
            fill3.Show();
        }

        private void FillFeederWin_Load(object sender, EventArgs e)
        {

        }

        private void closeFill(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
