using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Imaging;

namespace W_Maze_Gui
{
    public partial class Ephys : Form
    {
        public static string currrentRat = W_Maze_Gui.chosenRat;
        public static string folderPath = $@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Wmaze\RatData\{currrentRat}\Rat_EphysData\Session{W_Maze_Gui.sessionNumber}\";



        public Ephys()
        {
            InitializeComponent();
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);



        }



        // ##################################################################################################################################
        private void quality1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void enter_Click(object sender, EventArgs e)
        {
            box.Text = "";
            box.AppendText($"{DateTime.Now.ToString()} \r\n");
            //ACC
            box.AppendText(Environment.NewLine);
            box.AppendText("ACC TETRODES \r\n");
            box.AppendText(Environment.NewLine);
            box.AppendText($"Reference: Tetrode- {ACC_ref.Text}  AD Channel- {ACC_refAD.Text }\r\n");
            for (int i = 1; i <= 8; i++)
            {
                string qual = "quality" + i;
                string numbox = "num" + i;
                string lfp = "lfp" + i;
                string lfp_sec = "lfp_sec_" + i;

                CheckedListBox clb = (CheckedListBox)this.Controls[qual];
                if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText($"TT{i}: {clb.SelectedItem.ToString()}, Cells = {this.Controls[numbox].Text} ");
                }

                CheckedListBox clb_lfp = (CheckedListBox)this.Controls[lfp];
                CheckedListBox clb_lfp_sec = (CheckedListBox)this.Controls[lfp_sec];

                if (clb_lfp.CheckedItems.Count > 0 && clb_lfp_sec.CheckedItems.Count>0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp.SelectedItem.ToString()} {clb_lfp_sec.SelectedItem.ToString()} \r\n ");
                }
                else if (clb_lfp.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp.SelectedItem.ToString()} \r\n");
                }
                else if (clb_lfp_sec.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp_sec.SelectedItem.ToString()} \r\n");
                }
                else if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText(" \r\n");
                }
            }

            if (qualityrr.CheckedItems.Count > 0) { box.AppendText($"RR: {qualityrr.SelectedItem.ToString()}, Cells = {numrr.Text}  "); }
            if (lfprr.CheckedItems.Count > 0 || lfp_sec_rr.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP RR: {lfprr.SelectedItem.ToString()} {lfp_sec_rr.SelectedItem.ToString()} \r\n ");
            }
            else if (lfprr.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP RR: {lfprr.SelectedItem.ToString()} \r\n");
            }
            else if (lfp_sec_rr.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP RR: {lfp_sec_rr.SelectedItem.ToString()} \r\n");
            }

            box.AppendText(Environment.NewLine);

            //HIPPOCAMPUS


            box.AppendText("HIPPOCAMPUS TETRODES \r\n");
            box.AppendText(Environment.NewLine);
            box.AppendText($"Reference: Tetrode- {HC_ref.Text}  AD Channel- {HC_refAD.Text }\r\n");
            for (int i = 9; i <= 16; i++)
            {
                string qual = "quality" + i;
                string numbox = "num" + i;
                string lfp = "lfp" + i;
                string lfp_sec = "lfp_sec_" + i;

                CheckedListBox clb = (CheckedListBox)this.Controls[qual];
                if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText($"TT{i}: {clb.SelectedItem.ToString()}, Cells = {this.Controls[numbox].Text}  ");
                }
                CheckedListBox clb_lfp = (CheckedListBox)this.Controls[lfp];
                CheckedListBox clb_lfp_sec = (CheckedListBox)this.Controls[lfp_sec];
                if (clb_lfp.CheckedItems.Count > 0 && clb_lfp_sec.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp.SelectedItem.ToString()} {clb_lfp_sec.SelectedItem.ToString()} \r\n ");
                }
                else if (clb_lfp.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp.SelectedItem.ToString()} \r\n");
                }
                else if (clb_lfp_sec.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp_sec.SelectedItem.ToString()} \r\n");
                }
                else if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText(" \r\n");
                }

            }
            if (qualityrf.CheckedItems.Count > 0) { box.AppendText($"RF: {qualityrf.SelectedItem.ToString()}, Cells = {numrf.Text}  "); }
            if (lfprf.CheckedItems.Count > 0 || lfp_sec_rf.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP RF: {lfprf.SelectedItem.ToString()} {lfp_sec_rf.SelectedItem.ToString()} \r\n ");
            }
            else if (lfprf.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP: {lfprf.SelectedItem.ToString()} \r\n");
            }
            else if (lfp_sec_rf.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP: {lfp_sec_rf.SelectedItem.ToString()} \r\n");
            }

            box.AppendText(Environment.NewLine);

            box.AppendText("Changes during Session: \r\n");
            box.AppendText(Environment.NewLine);
            box.AppendText("Other Info:\r\n ");
            box.AppendText(Environment.NewLine);
            box.AppendText("Screenshots: \r\n");
        }

        private void box_TextChanged(object sender, EventArgs e)
        {

        }
        private string MergeRtfTexts(RichTextBox[] SourceRtbBoxes)
        {
            using (RichTextBox temp = new RichTextBox())
            {
                foreach (RichTextBox rtbSource in SourceRtbBoxes)
                {
                    rtbSource.SelectAll();
                    //move the end
                    temp.Select(temp.TextLength, 0);
                    //append the rtf
                    temp.SelectedRtf = rtbSource.SelectedRtf;
                }
                return temp.Rtf;
            }
        }
        // ##################################################################################################################################
        private void ephys_save_Click(object sender, EventArgs e)
        {

            string BoxText = box.Text.ToString();
            string DateTimeStr = DateTime.Now.ToString("MM-dd-yy");

            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            saveFile1.DefaultExt = ".rtf";
            saveFile1.FileName = $"{DateTimeStr}_ WM_Session{W_Maze_Gui.sessionNumber}";
            saveFile1.Filter = "RTF Files|*.rtf";

            //Directory
            
            
            saveFile1.InitialDirectory = folderPath;
            var bmpScreenCapture = new Bitmap(Width, Height);
            DrawToBitmap(bmpScreenCapture, new Rectangle(0, 0, bmpScreenCapture.Width, bmpScreenCapture.Height));
            bmpScreenCapture.Save(
                $@"{folderPath}EphysProperties.gif",ImageFormat.Gif);
            
            


            // Determine whether the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.

                final.Rtf = MergeRtfTexts(new RichTextBox[] { box, screenshots });
                final.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
                //rtb1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);   
            }

            Close();

        }

        private void quality2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Screenshot_Click(object sender, EventArgs e)
        {
            var screenshot_window = new Screenshot();
            screenshot_window.Show();
        }
    }
}

