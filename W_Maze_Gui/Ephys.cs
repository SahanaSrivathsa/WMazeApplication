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

namespace W_Maze_Gui
{
    public partial class Ephys : Form
    {
        public dynamic currrentRat = W_Maze_Gui.chosenRat;
        public static bool presleepStart = false;
        public static bool runStart = false;
        public static bool postsleepStart = false;



        public Ephys()
        {
            InitializeComponent();
            if (presleepStart == true) { box.AppendText("PRE-SLEEP \r\n"); }
            if (runStart == true) { box.AppendText("WMAZE RUN \r\n"); }
            if (postsleepStart == true) { box.AppendText("POST-SLEEP \r\n"); }


        }


        // ##################################################################################################################################
      
        private void enter_Click(object sender, EventArgs e)
        {
            enter.Hide();
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
                string cellProp = "cellProp" + i;


                CheckedListBox clb = (CheckedListBox)this.Controls[qual];
                if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText($"TT{i}: {clb.SelectedItem.ToString()}, Cells = {this.Controls[numbox].Text}, {this.Controls[cellProp].Text} ");
                }

                else if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText(" \r\n");
                }
            }

            if (qualityrr.CheckedItems.Count > 0) { box.AppendText($"RR: {qualityrr.SelectedItem.ToString()}, Cells = {numrr.Text}  , {cellPropRR.Text}"); }


            box.AppendText(Environment.NewLine);

            //HIPPOCAMPUS

            box.AppendText("HIPPOCAMPUS TETRODES \r\n");
            box.AppendText(Environment.NewLine);
            box.AppendText($"Reference: Tetrode- {HC_ref.Text}  AD Channel- {HC_refAD.Text }\r\n");
            for (int i = 9; i <= 16; i++)
            {
                string qual = "quality" + i;
                string numbox = "num" + i;
                string cellProp = "cellProp" + i;


                CheckedListBox clb = (CheckedListBox)this.Controls[qual];
                if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText($"TT{i}: {clb.SelectedItem.ToString()}, Cells = {this.Controls[numbox].Text} , {this.Controls[cellProp].Text} ");
                }

                else if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText(" \r\n");
                }

            }
            if (qualityrf.CheckedItems.Count > 0) { box.AppendText($"RF: {qualityrf.SelectedItem.ToString()}, Cells = {numrf.Text} , {cellPropRF.Text} "); }


            box.AppendText(Environment.NewLine);

            box.AppendText("Changes during Session: \r\n");
            box.AppendText(Environment.NewLine);
            
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
            saveFile1.FileName = $"{DateTimeStr}_ WM_Session  ";
            saveFile1.Filter = "RTF Files|*.rtf";

            //Directory
            string folderPath = $@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Wmaze\RatData\{currrentRat}\Rat_EphysData\";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            saveFile1.InitialDirectory = folderPath;


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


    }
}

