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
            this.IP_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm Cheetah is Open";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      
            // 
            // notRecordingButton
            // 
            this.notRecordingButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.notRecordingButton.Location = new System.Drawing.Point(145, 82);
            this.notRecordingButton.Name = "notRecordingButton";
            this.notRecordingButton.Size = new System.Drawing.Size(113, 37);
            this.notRecordingButton.TabIndex = 2;
            this.notRecordingButton.Text = "Not Recording";
            this.notRecordingButton.UseVisualStyleBackColor = false;
            this.notRecordingButton.Click += new System.EventHandler(this.notRecording);
            // 
            // IP_address
            // 
            this.IP_address.Location = new System.Drawing.Point(145, 43);
            this.IP_address.Name = "IP_address";
            this.IP_address.Size = new System.Drawing.Size(113, 20);
            this.IP_address.TabIndex = 3;
            this.IP_address.Text = "localhost";
            this.IP_address.TextChanged += new System.EventHandler(this.IP_address_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Address:";
            // 
            // NLXReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 130);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP_address);
            this.Controls.Add(this.notRecordingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmNLX);
            this.Name = "NLXReminder";
            this.Text = "NLXReminder";
            this.Load += new System.EventHandler(this.NLXReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmNLX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button notRecordingButton;
        private System.Windows.Forms.TextBox IP_address;
        private System.Windows.Forms.Label label2;
    }
}