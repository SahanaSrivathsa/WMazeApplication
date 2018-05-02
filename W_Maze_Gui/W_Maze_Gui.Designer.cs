namespace W_Maze_Gui
{
    partial class W_Maze_Gui
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_Maze_Gui));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.RatSelection = new System.Windows.Forms.ComboBox();
            this.Recording_Time = new System.Windows.Forms.Timer(this.components);
            this.display_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feederVisitTitle = new System.Windows.Forms.Label();
            this.Correct = new System.Windows.Forms.Label();
            this.totalIncorrect = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.correctNum = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.repeatNum = new System.Windows.Forms.Label();
            this.inboundNum = new System.Windows.Forms.Label();
            this.outboundNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.initialNum = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.totalNum = new System.Windows.Forms.Label();
            this.experimenterLabel = new System.Windows.Forms.Label();
            this.experimenterBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.ratSelectionLabel = new System.Windows.Forms.Label();
            this.totalErrNum = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.corOutNum = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.percentCorrect = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.nextCorrect = new System.Windows.Forms.Label();
            this.acquireButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(172)))), ((int)(((byte)(57)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(327, 195);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 54);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.Location = new System.Drawing.Point(452, 195);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(105, 54);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // RatSelection
            // 
            this.RatSelection.AllowDrop = true;
            this.RatSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RatSelection.DisplayMember = "RatSelection";
            this.RatSelection.DropDownHeight = 100;
            this.RatSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RatSelection.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RatSelection.FormattingEnabled = true;
            this.RatSelection.IntegralHeight = false;
            this.RatSelection.Location = new System.Drawing.Point(716, 93);
            this.RatSelection.Name = "RatSelection";
            this.RatSelection.Size = new System.Drawing.Size(101, 21);
            this.RatSelection.Sorted = true;
            this.RatSelection.TabIndex = 3;
            this.RatSelection.SelectedIndexChanged += new System.EventHandler(this.ratSelectionBox_SelectedIndexChanged);
            this.RatSelection.Click += new System.EventHandler(this.ratSelectionBox_SelectedIndexChanged);
            // 
            // Recording_Time
            // 
            this.Recording_Time.Interval = 1000;
            this.Recording_Time.Tick += new System.EventHandler(this.increment_time);
            // 
            // display_time
            // 
            this.display_time.AutoSize = true;
            this.display_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_time.ForeColor = System.Drawing.Color.RoyalBlue;
            this.display_time.Location = new System.Drawing.Point(326, 68);
            this.display_time.MinimumSize = new System.Drawing.Size(200, 100);
            this.display_time.Name = "display_time";
            this.display_time.Size = new System.Drawing.Size(237, 100);
            this.display_time.TabIndex = 5;
            this.display_time.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(709, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rat Number";
            // 
            // feederVisitTitle
            // 
            this.feederVisitTitle.AutoSize = true;
            this.feederVisitTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feederVisitTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.feederVisitTitle.Location = new System.Drawing.Point(15, 19);
            this.feederVisitTitle.Name = "feederVisitTitle";
            this.feederVisitTitle.Size = new System.Drawing.Size(153, 22);
            this.feederVisitTitle.TabIndex = 8;
            this.feederVisitTitle.Text = "Feeder Visits";
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct.ForeColor = System.Drawing.SystemColors.Control;
            this.Correct.Location = new System.Drawing.Point(3, 8);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(62, 18);
            this.Correct.TabIndex = 9;
            this.Correct.Text = "Correct:";
            this.Correct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalIncorrect
            // 
            this.totalIncorrect.AutoSize = true;
            this.totalIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncorrect.ForeColor = System.Drawing.SystemColors.Control;
            this.totalIncorrect.Location = new System.Drawing.Point(3, 3);
            this.totalIncorrect.Name = "totalIncorrect";
            this.totalIncorrect.Size = new System.Drawing.Size(66, 18);
            this.totalIncorrect.TabIndex = 10;
            this.totalIncorrect.Text = "Incorrect";
            this.totalIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.SystemColors.Control;
            this.Total.Location = new System.Drawing.Point(3, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(51, 18);
            this.Total.TabIndex = 11;
            this.Total.Text = "Total:";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Session No.:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ageLabel.Location = new System.Drawing.Point(47, 18);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 18);
            this.ageLabel.TabIndex = 16;
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionLabel.ForeColor = System.Drawing.Color.Cyan;
            this.sessionLabel.Location = new System.Drawing.Point(112, 72);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(0, 18);
            this.sessionLabel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sessionLabel);
            this.panel1.Location = new System.Drawing.Point(688, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 114);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ageLabel);
            this.panel2.Location = new System.Drawing.Point(688, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 58);
            this.panel2.TabIndex = 19;
            // 
            // correctNum
            // 
            this.correctNum.AutoSize = true;
            this.correctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctNum.ForeColor = System.Drawing.Color.Cyan;
            this.correctNum.Location = new System.Drawing.Point(24, 6);
            this.correctNum.Name = "correctNum";
            this.correctNum.Size = new System.Drawing.Size(19, 20);
            this.correctNum.TabIndex = 20;
            this.correctNum.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(704, 584);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 44);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.feederVisitTitle);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 63);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.Correct);
            this.panel4.Location = new System.Drawing.Point(12, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 38);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 38);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.repeatNum);
            this.panel6.Controls.Add(this.inboundNum);
            this.panel6.Controls.Add(this.outboundNum);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.initialNum);
            this.panel6.Controls.Add(this.totalIncorrect);
            this.panel6.Location = new System.Drawing.Point(12, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 135);
            this.panel6.TabIndex = 24;
            // 
            // repeatNum
            // 
            this.repeatNum.AutoSize = true;
            this.repeatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatNum.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.repeatNum.Location = new System.Drawing.Point(93, 103);
            this.repeatNum.Name = "repeatNum";
            this.repeatNum.Size = new System.Drawing.Size(16, 18);
            this.repeatNum.TabIndex = 18;
            this.repeatNum.Text = "0";
            // 
            // inboundNum
            // 
            this.inboundNum.AutoSize = true;
            this.inboundNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboundNum.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.inboundNum.Location = new System.Drawing.Point(93, 79);
            this.inboundNum.Name = "inboundNum";
            this.inboundNum.Size = new System.Drawing.Size(16, 18);
            this.inboundNum.TabIndex = 17;
            this.inboundNum.Text = "0";
            // 
            // outboundNum
            // 
            this.outboundNum.AutoSize = true;
            this.outboundNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboundNum.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.outboundNum.Location = new System.Drawing.Point(93, 53);
            this.outboundNum.Name = "outboundNum";
            this.outboundNum.Size = new System.Drawing.Size(16, 18);
            this.outboundNum.TabIndex = 16;
            this.outboundNum.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "repeat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "inbound:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "outbound:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "initial:";
            // 
            // initialNum
            // 
            this.initialNum.AutoSize = true;
            this.initialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialNum.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.initialNum.Location = new System.Drawing.Point(93, 28);
            this.initialNum.Name = "initialNum";
            this.initialNum.Size = new System.Drawing.Size(16, 18);
            this.initialNum.TabIndex = 11;
            this.initialNum.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.Total);
            this.panel7.Location = new System.Drawing.Point(12, 237);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(119, 41);
            this.panel7.TabIndex = 25;
            // 
            // totalNum
            // 
            this.totalNum.AutoSize = true;
            this.totalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNum.ForeColor = System.Drawing.Color.Cyan;
            this.totalNum.Location = new System.Drawing.Point(24, 178);
            this.totalNum.Name = "totalNum";
            this.totalNum.Size = new System.Drawing.Size(19, 20);
            this.totalNum.TabIndex = 26;
            this.totalNum.Text = "0";
            // 
            // experimenterLabel
            // 
            this.experimenterLabel.AutoSize = true;
            this.experimenterLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experimenterLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.experimenterLabel.Location = new System.Drawing.Point(269, 335);
            this.experimenterLabel.Name = "experimenterLabel";
            this.experimenterLabel.Size = new System.Drawing.Size(138, 18);
            this.experimenterLabel.TabIndex = 26;
            this.experimenterLabel.Text = "Experimenter:";
            // 
            // experimenterBox
            // 
            this.experimenterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.experimenterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.experimenterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experimenterBox.ForeColor = System.Drawing.Color.White;
            this.experimenterBox.Location = new System.Drawing.Point(413, 338);
            this.experimenterBox.Name = "experimenterBox";
            this.experimenterBox.Size = new System.Drawing.Size(137, 15);
            this.experimenterBox.TabIndex = 27;
            // 
            // notesBox
            // 
            this.notesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.ForeColor = System.Drawing.Color.White;
            this.notesBox.Location = new System.Drawing.Point(272, 401);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(333, 193);
            this.notesBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(269, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Notes";
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.Cyan;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.Black;
            this.selectButton.Location = new System.Drawing.Point(727, 120);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 30;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.SelectButtonClick);
            // 
            // ratSelectionLabel
            // 
            this.ratSelectionLabel.AutoSize = true;
            this.ratSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSelectionLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ratSelectionLabel.Location = new System.Drawing.Point(727, 97);
            this.ratSelectionLabel.Name = "ratSelectionLabel";
            this.ratSelectionLabel.Size = new System.Drawing.Size(0, 25);
            this.ratSelectionLabel.TabIndex = 31;
            // 
            // totalErrNum
            // 
            this.totalErrNum.AutoSize = true;
            this.totalErrNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalErrNum.ForeColor = System.Drawing.Color.Cyan;
            this.totalErrNum.Location = new System.Drawing.Point(24, 53);
            this.totalErrNum.Name = "totalErrNum";
            this.totalErrNum.Size = new System.Drawing.Size(19, 20);
            this.totalErrNum.TabIndex = 19;
            this.totalErrNum.Text = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.totalNum);
            this.panel8.Location = new System.Drawing.Point(128, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(71, 210);
            this.panel8.TabIndex = 32;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.correctNum);
            this.panel9.Location = new System.Drawing.Point(128, 68);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(71, 38);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.totalErrNum);
            this.panel10.Location = new System.Drawing.Point(128, 104);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(71, 135);
            this.panel10.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 36;
            // 
            // fillButton
            // 
            this.fillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fillButton.Location = new System.Drawing.Point(716, 422);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(86, 36);
            this.fillButton.TabIndex = 37;
            this.fillButton.Text = "FILL";
            this.fillButton.UseVisualStyleBackColor = false;
            this.fillButton.Click += new System.EventHandler(this.fillFeeders);
            // 
            // cleanButton
            // 
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cleanButton.Location = new System.Drawing.Point(716, 486);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(86, 36);
            this.cleanButton.TabIndex = 38;
            this.cleanButton.Text = "CLEAN";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanFeeders);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(39, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Correct Outbound";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.corOutNum);
            this.panel11.Location = new System.Drawing.Point(42, 334);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(125, 54);
            this.panel11.TabIndex = 39;
            // 
            // corOutNum
            // 
            this.corOutNum.AutoSize = true;
            this.corOutNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corOutNum.ForeColor = System.Drawing.Color.Cyan;
            this.corOutNum.Location = new System.Drawing.Point(41, 12);
            this.corOutNum.Name = "corOutNum";
            this.corOutNum.Size = new System.Drawing.Size(38, 25);
            this.corOutNum.TabIndex = 40;
            this.corOutNum.Text = "00";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.percentCorrect);
            this.panel12.Location = new System.Drawing.Point(42, 424);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(125, 56);
            this.panel12.TabIndex = 40;
            // 
            // percentCorrect
            // 
            this.percentCorrect.AutoSize = true;
            this.percentCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentCorrect.ForeColor = System.Drawing.Color.Cyan;
            this.percentCorrect.Location = new System.Drawing.Point(35, 12);
            this.percentCorrect.Name = "percentCorrect";
            this.percentCorrect.Size = new System.Drawing.Size(0, 25);
            this.percentCorrect.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(17, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Percent Correct Outbound";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(31, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Next Correct Location";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.nextCorrect);
            this.panel13.Location = new System.Drawing.Point(43, 524);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(125, 46);
            this.panel13.TabIndex = 42;
            // 
            // nextCorrect
            // 
            this.nextCorrect.AutoSize = true;
            this.nextCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextCorrect.Location = new System.Drawing.Point(24, 10);
            this.nextCorrect.Name = "nextCorrect";
            this.nextCorrect.Size = new System.Drawing.Size(73, 20);
            this.nextCorrect.TabIndex = 43;
            this.nextCorrect.Text = "Feeder 2";
            // 
            // acquireButton
            // 
            this.acquireButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acquireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.acquireButton.ForeColor = System.Drawing.Color.Yellow;
            this.acquireButton.Location = new System.Drawing.Point(688, 209);
            this.acquireButton.Name = "acquireButton";
            this.acquireButton.Size = new System.Drawing.Size(69, 40);
            this.acquireButton.TabIndex = 43;
            this.acquireButton.Text = "ACQUIRE";
            this.acquireButton.UseVisualStyleBackColor = true;
            this.acquireButton.Click += new System.EventHandler(this.acquireButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recordButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.recordButton.Location = new System.Drawing.Point(769, 209);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(69, 40);
            this.recordButton.TabIndex = 44;
            this.recordButton.Text = "RECORD";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // W_Maze_Gui
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(908, 661);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.acquireButton);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.experimenterBox);
            this.Controls.Add(this.experimenterLabel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_time);
            this.Controls.Add(this.RatSelection);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ratSelectionLabel);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "W_Maze_Gui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W-Maze";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.W_Maze_Gui_FormClosing);
            this.Load += new System.EventHandler(this.W_Maze_Gui_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox RatSelection;
        private System.Windows.Forms.Timer Recording_Time;
        private System.Windows.Forms.Label display_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feederVisitTitle;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.Label totalIncorrect;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label correctNum;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label initialNum;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label totalNum;
        private System.Windows.Forms.Label experimenterLabel;
        private System.Windows.Forms.TextBox experimenterBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label ratSelectionLabel;
        private System.Windows.Forms.Label repeatNum;
        public System.Windows.Forms.Label inboundNum;
        private System.Windows.Forms.Label outboundNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalErrNum;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label corOutNum;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label percentCorrect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label nextCorrect;
        private System.Windows.Forms.Button acquireButton;
        private System.Windows.Forms.Button recordButton;
    }
}

