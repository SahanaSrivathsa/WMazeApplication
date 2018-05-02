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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                new W_Maze_Gui().Show();

            }

        }
       public void killMe()
        {
            this.Close();
        }
    }
}
