namespace W_Maze_Gui
{
    partial class Screenshot
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
            this.save_screenshot = new System.Windows.Forms.Button();
            this.screenshot_caption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save_screenshot
            // 
            this.save_screenshot.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_screenshot.Location = new System.Drawing.Point(42, 82);
            this.save_screenshot.Name = "save_screenshot";
            this.save_screenshot.Size = new System.Drawing.Size(192, 43);
            this.save_screenshot.TabIndex = 0;
            this.save_screenshot.Text = "Save Screenshot";
            this.save_screenshot.UseVisualStyleBackColor = true;
            this.save_screenshot.Click += new System.EventHandler(this.button1_Click);
            // 
            // screenshot_caption
            // 
            this.screenshot_caption.Location = new System.Drawing.Point(42, 36);
            this.screenshot_caption.Name = "screenshot_caption";
            this.screenshot_caption.Size = new System.Drawing.Size(192, 20);
            this.screenshot_caption.TabIndex = 1;
            this.screenshot_caption.TextChanged += new System.EventHandler(this.screenshot_caption_TextChanged);
            // 
            // Screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 137);
            this.Controls.Add(this.screenshot_caption);
            this.Controls.Add(this.save_screenshot);
            this.Name = "Screenshot";
            this.Text = "Screenshot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_screenshot;
        private System.Windows.Forms.TextBox screenshot_caption;
    }
}