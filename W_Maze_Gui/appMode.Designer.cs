namespace W_Maze_Gui
{
    partial class appMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainModeButton = new System.Windows.Forms.Button();
            this.testModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What application mode would";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "you like to run?";
            // 
            // trainModeButton
            // 
            this.trainModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainModeButton.Location = new System.Drawing.Point(33, 112);
            this.trainModeButton.Name = "trainModeButton";
            this.trainModeButton.Size = new System.Drawing.Size(94, 44);
            this.trainModeButton.TabIndex = 2;
            this.trainModeButton.Text = "TRAINING";
            this.trainModeButton.UseVisualStyleBackColor = true;
            this.trainModeButton.Click += new System.EventHandler(this.trainModeButton_Click);
            // 
            // testModeButton
            // 
            this.testModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testModeButton.Location = new System.Drawing.Point(187, 112);
            this.testModeButton.Name = "testModeButton";
            this.testModeButton.Size = new System.Drawing.Size(85, 44);
            this.testModeButton.TabIndex = 3;
            this.testModeButton.Text = "TESTING";
            this.testModeButton.UseVisualStyleBackColor = true;
            this.testModeButton.Click += new System.EventHandler(this.testModeButton_Click);
            // 
            // appMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(307, 199);
            this.Controls.Add(this.testModeButton);
            this.Controls.Add(this.trainModeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "appMode";
            this.Text = "What Mode?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button trainModeButton;
        private System.Windows.Forms.Button testModeButton;
    }
}