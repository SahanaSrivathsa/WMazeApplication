namespace W_Maze_Gui
{
    partial class NLXReminder
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
            this.ConfirmNLX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notRecordingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmNLX
            // 
            this.ConfirmNLX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmNLX.Location = new System.Drawing.Point(16, 82);
            this.ConfirmNLX.Name = "ConfirmNLX";
            this.ConfirmNLX.Size = new System.Drawing.Size(113, 37);
            this.ConfirmNLX.TabIndex = 0;
            this.ConfirmNLX.Text = "Confirm";
            this.ConfirmNLX.UseVisualStyleBackColor = false;
            this.ConfirmNLX.Click += new System.EventHandler(this.confirm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm that Cheetah is Open";
            // 
            // notRecordingButton
            // 
            this.notRecordingButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.notRecordingButton.Location = new System.Drawing.Point(153, 82);
            this.notRecordingButton.Name = "notRecordingButton";
            this.notRecordingButton.Size = new System.Drawing.Size(113, 37);
            this.notRecordingButton.TabIndex = 2;
            this.notRecordingButton.Text = "Not Recording";
            this.notRecordingButton.UseVisualStyleBackColor = false;
            // 
            // NLXReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 131);
            this.Controls.Add(this.notRecordingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmNLX);
            this.Name = "NLXReminder";
            this.Text = "NLXReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmNLX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button notRecordingButton;
    }
}