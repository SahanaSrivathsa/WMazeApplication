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
using MNetCom;


namespace W_Maze_Gui
{
    
    public partial class NLXReminder : Form
    {
        #region Private Members
        public static MNetCom.MNetComClient mNetComClient;
        private W_Maze_Gui _gui;
        #endregion
        

        public NLXReminder(W_Maze_Gui gui)
        {
            _gui = gui;
            mNetComClient = W_Maze_Gui.mNetComClient;
            InitializeComponent();
        }

        private void confirm(object sender, EventArgs e)
        {
            if (mNetComClient.ConnectToServer(this.IP_address.Text))
            {
                var isNlxConnected = mNetComClient.AreWeConnected();
                if (!isNlxConnected)
                {
                    MessageBox.Show(this, "Connection to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
                    
                }
                else
                {
                    MessageBox.Show(this, "Connected to Server", "NetCom Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
                //string reply = "";
                //mNetComClient.SendCommand("-PostEvent \"ConnectedToWMaze\" 0 0", ref reply);
                this.IP_address.Enabled = false;
                Close();
            }
            else
            {
                MessageBox.Show(this, "Connection to server failed", "NetCom Error", MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void notRecording(object sender, EventArgs e)
        {
            Close();
            _gui.disable_NLX();
                
        }


        private void NLXReminder_Load(object sender, EventArgs e)
        {

        }

        private void IP_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


