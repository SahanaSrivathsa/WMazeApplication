using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;



namespace W_Maze_Gui
{
    public partial class Screenshot : Form
    
    {
        
        public string folderPath = Ephys.folderPath;
        private EncoderParameters encoderParams;

        public static Image GetImageFromClipboard()
        {
            Image clipImage = null;
            if (Clipboard.ContainsImage())
            {
                clipImage = Clipboard.GetImage();
            }
            return clipImage;
        }
        public Screenshot()
        {
            InitializeComponent();
        }

        private void screenshot_caption_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Clipboard.ContainsImage() == true)
            {
                Image clipImage = GetImageFromClipboard();
                string timestamp = DateTime.Now.ToString("Hms");
                string cap = $@"{folderPath}{screenshot_caption.Text.ToString()}_{timestamp}.gif";
                Console.Write(cap);
                clipImage.Save(cap, ImageFormat.Gif);
                Clipboard.Clear();
                this.Close();
            }

            else
            {
                MessageBox.Show(this, "No Image on Clipboard", "Image not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }
                
            

        }



    }
}
