namespace W_Maze_Gui
{
    partial class FillFeederWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillFeederWin));
            this.formTitle = new System.Windows.Forms.Label();
            this.fill1 = new System.Windows.Forms.Button();
            this.fill2 = new System.Windows.Forms.Button();
            this.fill3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(219, 25);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(176, 32);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Fill Feeders";
            // 
            // fill1
            // 
            this.fill1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill1.Location = new System.Drawing.Point(136, 111);
            this.fill1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fill1.Name = "fill1";
            this.fill1.Size = new System.Drawing.Size(73, 47);
            this.fill1.TabIndex = 5;
            this.fill1.Text = "Fill F1";
            this.fill1.UseVisualStyleBackColor = true;
            this.fill1.Click += new System.EventHandler(this.fill1_click);
            // 
            // fill2
            // 
            this.fill2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill2.Location = new System.Drawing.Point(277, 111);
            this.fill2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fill2.Name = "fill2";
            this.fill2.Size = new System.Drawing.Size(75, 46);
            this.fill2.TabIndex = 6;
            this.fill2.Text = "Fill F2";
            this.fill2.UseVisualStyleBackColor = true;
            this.fill2.Click += new System.EventHandler(this.fill2_click);
            // 
            // fill3
            // 
            this.fill3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill3.Location = new System.Drawing.Point(416, 110);
            this.fill3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fill3.Name = "fill3";
            this.fill3.Size = new System.Drawing.Size(75, 48);
            this.fill3.TabIndex = 7;
            this.fill3.Text = "Fill F3";
            this.fill3.UseVisualStyleBackColor = true;
            this.fill3.Click += new System.EventHandler(this.fill3_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.close1_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(277, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.close2_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(416, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "STOP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.close3_click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(509, 437);
            this.doneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(109, 57);
            this.doneButton.TabIndex = 11;
            this.doneButton.Text = "Done Filling";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.closeFill);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FillFeederWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(645, 519);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.fill3);
            this.Controls.Add(this.fill2);
            this.Controls.Add(this.fill1);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FillFeederWin";
            this.Text = "FillFeederWin";
            this.Load += new System.EventHandler(this.FillFeederWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button fill1;
        private System.Windows.Forms.Button fill2;
        private System.Windows.Forms.Button fill3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}