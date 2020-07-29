using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TestStack.White;
using W_Maze_Gui.TCPConnection;
using static W_Maze_Gui.TCPConnection.TcpServer;
using TestStack;
using TestStack.White;
using TestStack.White.InputDevices;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.WindowsAPI;
using System.Linq;
using MNetCom;

//using System.Imaging;

namespace W_Maze_Gui
{
    public partial class W_Maze_Gui : Form
    {
        private static readonly SerialPort serialPort = new SerialPort();
        //recently made static; if there are issues with making an instance of W_Maze_GUI, change back

        private readonly Form exitConfirm = new ExitConfirm();
        private readonly Form reminderWindow;
        //private readonly Form modeWindow;
        private readonly Dictionary<string, string> name_to_age = new Dictionary<string, string>();
        private readonly Dictionary<string, int> name_to_session = new Dictionary<string, int>();
        private readonly List<string> ratName = new List<string>();
        private int _elapsed_time;
        private string run_time;
        private bool _exiting;
        public int correctCnt;
        public string day;
        public BackgroundWorker felix = new BackgroundWorker();
        public string hour;
        public double inboundCnt;
        public double initialCnt;
        public string lastMessage;
        public string minute;
        public string month;
        public double outboundCnt;
        private List<string> ratAge = new List<string>();
        public string ratbeingtested;
        private List<string> ratSession = new List<string>();
        private bool ratWasChosen;
        public bool selectedRat = false;
        public static dynamic chosenRat;
        public double repeatCnt;
        public bool saved;
        private bool SessionHasBegun;
        public static string sessionNumber;
        public bool splash = true;
        public double totes;
        public string year;
        public double corOut = 0;
        public double corInb = 0;
        public double percentCor = 0;
        public double inboundPercentCor = 0;
        public int last = 0;
        public bool started = false;
        public bool newSesh { get; set; } = false;
        private TcpServer _sender;
        public DateTime startdTime = DateTime.Now;
        private bool _recording;
        public bool acquiring = false;
        public string notesReformatted;
        public string notes_behaviourReformatted;
        public string experimenterReformatted;
        public bool train;
        public static MNetCom.MNetComClient mNetComClient;
        public static bool recordingStatus = true;
        public static string newRatNo;
        public static string newRatAge;
        public string dateString;




        private Window NeuraLynxWindow { get; }

        public W_Maze_Gui()
        {   

            //Arduino Basic commands set and connected to port
            CsvFiles.OpenRatDataCsv(); //open RatData.csv so we can read from it and access Rat info
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";
            serialPort.ReadTimeout = 10000;
            serialPort.Encoding = Encoding.UTF8;
            serialPort.DiscardNull = true;
            serialPort.WriteBufferSize = 10000;
            serialPort.Open();

            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();


        
            while (!CsvFiles.RatdataReader.EndOfStream)
            //this reads the RatData.csv file and makes a dictionary for the ages and for the session number
            {
                var line = CsvFiles.RatdataReader.ReadLine();
                var vals = line.Split(',');
                name_to_age.Add(vals[0], vals[1]);
                name_to_session.Add(vals[0], int.Parse(vals[2]));
                ratName.Add(vals[0]);
            }
            CsvFiles.CloseRatDataCsv();

            //Initializes MNetcom to connect to NETCOM for ONLINE connection with CHEETAH
            mNetComClient = new MNetCom.MNetComClient();
            




            InitializeComponent();
            foreach (var rat in ratName) this.RatSelection.Items.Add(rat);
            this.RatSelection.Items.Add("New Rat");  //option to create new rat

            //Displays time and date on GUI window    
            dateString = DateTime.Now.ToShortDateString();
            rat_datelabel.Text = DateTime.Now.ToShortDateString();
            rat_timelabel.Text = DateTime.Now.ToShortTimeString();



            reminderWindow = new NLXReminder(this);
            //modeWindow = new appMode(this);
            confirm();
            //if (recordingStatus == false) { ephys.Hide(); }

        }

        private static string fixDateTime(int x)
        {
            return x < 10 ? $"0{x}" : x.ToString();
        }

        private void W_Maze_Gui_Load(object sender, EventArgs e) //When the Gui window loads do the following
        {
            cleanButton.Hide();
            selectButton.Enabled = false;
            ephys.Hide();
            startButton.Hide();
            stopButton.Hide();

            var moment = new DateTime();
            year = moment.Year.ToString();
            month = fixDateTime(moment.Month);
            day = fixDateTime(moment.Day);
            minute = fixDateTime(moment.Minute);
            hour = fixDateTime(moment.Hour);
        }
        
        public void listen_to_arduino(object sender, DoWorkEventArgs e)
        //The "listener" that is the mediator between the worker (Felix) and the updater
        {
            try
            {
                var changedData = serialPort.ReadTo("\n");
                e.Result = changedData;
            }
            catch (Exception)
            {
            }
        }

        private void SelectButtonClick(object sender, EventArgs e)
        //When you click "Select" you lock in the rat number and info
        {
            
            cleanButton.Show();
            if (RatSelection.SelectedIndex >= 0)
            {
                selectButton.Hide();
                RatSelection.Hide();
                
                if (recordingStatus == true)
                {
                    startPreSleep.Show();
                    stopPreSleep.Show();
                }
                ephys.Show();
                startButton.Show();
                stopButton.Show();

                selectedRat = true;
                saveButton.Enabled = true;

                if (RatSelection.Text == "New Rat")
                {
                    var rat_entry = new NewRat();
                    rat_entry.ShowDialog();
                    ratName.Add(newRatNo);
                    //Console.WriteLine($"The NEW RAT NO IS {newRatNo}");
                    name_to_age.Add(newRatNo,newRatAge);
                    name_to_session.Add(newRatNo, 0);

                    chosenRat = newRatNo;
                    ratSelectionLabel.Text = newRatNo;
                    
                }
                else
                {
                    ratSelectionLabel.Text = $"{ratName[RatSelection.SelectedIndex]}";
                    chosenRat = ratName[RatSelection.SelectedIndex];
                }
                    
                ageLabel.Text = name_to_age[chosenRat];
                
                    sessionLabel.Text = name_to_session[chosenRat].ToString();
                   
                    CsvFiles.OpenSessionCsv(chosenRat);
                    CsvFiles.OpenWriteToRatData();
                    foreach (var ratname in name_to_age.Keys)
                    {
                        if (ratname == chosenRat)
                            name_to_session[ratname]++;
                        CsvFiles.RatdataWriter.Write(
                            $"{ratname},{name_to_age[ratname]},{name_to_session[ratname]}\n");
                    }
                    sessionNumber = (name_to_session[chosenRat] - 1).ToString();
                    CsvFiles.OpenTimestampCsv(chosenRat, sessionNumber);
                    CsvFiles.TimestampCsv.Write("Feeder,Type,Timestamp\n");
                    CsvFiles.RatdataClose();
                
                
                ratWasChosen = true;
                if (recordingStatus == true)
                {
                    string reply = "";

                    if (!(mNetComClient.SendCommand($"-ProcessConfigurationFile WMAZE_HALO_Ephys_Setup_{chosenRat}.cfg", ref reply)))
                    {
                        MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        String[] parsedReplyString = reply.Split(' ');
                        if (0 < parsedReplyString.GetLength(0))
                        {
                            if (parsedReplyString[0].Equals("-1"))
                            {
                                MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }

                    }
                    if (!(mNetComClient.SendCommand($"-SetDataDirectory \"I:\\CurrentCheetahData\\10732\\WMaze_10732\\{dateString}-Session{sessionNumber}\"", ref reply)))
                    {
                        MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        String[] parsedReplyString = reply.Split(' ');
                        if (0 < parsedReplyString.GetLength(0))
                        {
                            if (parsedReplyString[0].Equals("-1"))
                            {
                                MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }

                    }
                }
                
                ratbeingtested = ratName[RatSelection.SelectedIndex];
                

            }
        }

        public void StartButtonClick(object sender, EventArgs e)
        //Clicking "Start" starts the timer and you can only start after you have selected a rat and locked it in
        {
            fillButton.Hide();
            
            if (ratWasChosen)
            {
               

                Recording_Time.Enabled = true;
                SessionHasBegun = true;
                updateTime();
                if (recordButton.BackColor != Color.AliceBlue && recordingStatus == true)
                {
                    if (MessageBox.Show(this, "Is Cheetah Recording", "Cheetah Recording", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        SessionHasBegun = false;
                    }
                    else { SessionHasBegun = true; }
                }
                else { SessionHasBegun = true; }


                string reply = "";
                if (!(mNetComClient.SendCommand("-PostEvent \"StartWM\" 0 0", ref reply)) && recordingStatus == true)
                {
                    MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    String[] parsedReplyString = reply.Split(' ');
                    if (0 < parsedReplyString.GetLength(0))
                    {
                        if (parsedReplyString[0].Equals("-1"))
                        {
                            MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }

                }

                if (SessionHasBegun == true)
                {
                    startButton.ForeColor = Color.AliceBlue;

                    _elapsed_time = 0;
                    Recording_Time.Enabled = true;
                    updateTime();
                    startPreSleep.Visible = false;
                    stopPreSleep.Visible = false;
                    startButton.Enabled = false;

                    //Felix(The BackroundWorker)
                    felix.DoWork += listen_to_arduino;
                    felix.RunWorkerCompleted += run_worker_completed;
                    felix.RunWorkerAsync();
                }
                
                
                

            }

            else
            {
                var ratWindow = new SelectRatWindow();
                ratWindow.StartPosition = FormStartPosition.CenterParent;
                ratWindow.ShowDialog();
                
            }

            try //sends a message to the UNO to reinitialize variables
            {
                var message = new char[1] { 'L' };
                serialPort.Write(message, 0, 1);
            }
            catch (Exception)
            {
            }


        }


        private void increment_time(object sender, EventArgs e) //Allows the timer to tick up
        {
            _elapsed_time += 1;
            updateTime();
        }

        private void updateTime() //Displays the current length of the session
        {
            var mins_ones = _elapsed_time / 60 % 10;
            var mins_tens = _elapsed_time / 60 / 10;
            var secs_ones = _elapsed_time % 60 % 10;
            var secs_tens = _elapsed_time % 60 / 10;
            display_time.Text = $"{mins_tens}{mins_ones}:{secs_tens}{secs_ones}";
        }

        private void stopButton_Click(object sender, EventArgs e) //Clicking "Stop" stops the timer
        {
            startButton.ForeColor = Color.FromArgb(0, 40, 0);
            Recording_Time.Enabled = false;
            run_time = display_time.Text;
            _elapsed_time = 0;

            string reply = "";
            if (recordingStatus == true)
            {
                if (!(mNetComClient.SendCommand("-PostEvent \"StopWM\" 0 0", ref reply)))
                {
                    MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    String[] parsedReplyString = reply.Split(' ');
                    if (0 < parsedReplyString.GetLength(0))
                    {
                        if (parsedReplyString[0].Equals("-1"))
                        {
                            MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }

                }
                startPostSleep.Visible = true;
                stopPostSleep.Visible = true;
            }
            
            stopButton.Enabled = false;
            startButton.Enabled = false;
            
        }

        private void ratSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        //Enables the select button when you choose a rat from the combo box
        {
            selectButton.Enabled = true;

        }

        private void SaveButtonClick(object sender, EventArgs e)
        //Hitting the save button saves the session info to SessionInfo_{rat#} as well as a screen shot of the GUI
        {
            if (ratWasChosen)
            {
                Show();
                saveButton.ForeColor = Color.DarkGray;
                saveButton.Enabled = false;
                //notesReformatted =  notesBox.Text.Replace("," , ";");
                notes_behaviourReformatted=notesBox_behaviour.Text.Replace(",", ";");
                experimenterReformatted = experimenterBox.Text.Replace(",", ";");
                
                
                    CsvFiles.SessionCsv.Write(
                        $"{sessionLabel.Text},{experimenterReformatted},{DateTime.Now},{run_time},{correctNum.Text},{initialNum.Text},{outboundNum.Text},{inboundNum.Text},{repeatNum.Text},{totalErrNum.Text},{totalNum.Text},{notes_behaviourReformatted}\n");
                    CsvFiles.Close();
                    if (
                        !Directory.Exists(
                            $@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Wmaze\RatData\{ratName[RatSelection.SelectedIndex]}\ScreenShots"))
                        Directory.CreateDirectory(
                            $@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Wmaze\RatData\{ratName[RatSelection.SelectedIndex]}\ScreenShots");
                    var bmpScreenCapture = new Bitmap(Width, Height);
                    DrawToBitmap(bmpScreenCapture, new Rectangle(0, 0, bmpScreenCapture.Width, bmpScreenCapture.Height));
                    bmpScreenCapture.Save(
                        $@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Wmaze\RatData\{ratName[RatSelection.SelectedIndex]}\ScreenShots\GUIscreenshot_{ratName
                            [RatSelection.SelectedIndex]}_Session{sessionNumber}.gif",
                        ImageFormat.Gif);
                    
                
                saved = true;


            }
        }

        private void W_Maze_Gui_FormClosing(object sender, FormClosingEventArgs e)
        //Opens the exitConfirm form to ensure that you are purposefully exiting the GUI
        {
            if (!_exiting)
            {
                if (!saved)
                {
                    _exiting = true;
                    exitConfirm.StartPosition = FormStartPosition.CenterParent;
                    exitConfirm.ShowDialog();
                    e.Cancel = true;
                    _exiting = false;

                    if (train)
                    {
                        CsvFiles.trainingCsv.Close();
                    }

                    if (ratWasChosen && !train)
                    {
                        CsvFiles.OpenWriteToRatData();

                        foreach (var ratname in name_to_age.Keys)
                        {
                            if (ratname == ratbeingtested)
                                name_to_session[ratname]--;
                            CsvFiles.RatdataWriter.Write(
                                $"{ratname},{name_to_age[ratname]},{name_to_session[ratname]}\n");

                        }
                        CsvFiles.RatdataClose();
                        CsvFiles.Close();
                    }
                }
                else
                {

                    if (!train)
                    {
                        CsvFiles.RatdataClose();
                        CsvFiles.Close();
                    }
                    Environment.Exit(0);
                    
                }

            }
        }

        private void fillFeeders(object sender, EventArgs e) //opens the fill feeders window
        {
            var fill_feeders = new FillFeederWin();
            fill_feeders.StartPosition = FormStartPosition.CenterParent;
            fill_feeders.ShowDialog();
        }

        private void cleanFeeders(object sender, EventArgs e) //opens the clean feeders window
        {
            using (var fill_feeders = new FillFeederWin())
            {
                fill_feeders.timeToClean();
                fill_feeders.StartPosition = FormStartPosition.CenterParent;
                fill_feeders.ShowDialog();
            }
        }

        public void confirm()
        {
            reminderWindow.StartPosition = FormStartPosition.CenterParent;
            reminderWindow.ShowDialog();
            //modeWindow.StartPosition = FormStartPosition.CenterParent;
            //modeWindow.ShowDialog();
        }
        public static void sendMessage(string button) //handles messages to be sent to the UNO for filling/cleaning
        {
            switch (button)
            {
                case "1":
                    try
                    {
                        serialPort.Write(new[] { 'X' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "2":
                    try
                    {
                        serialPort.Write(new[] { 'Y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "3":
                    try
                    {
                        serialPort.Write(new[] { 'Z' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "11":
                    try
                    {
                        serialPort.Write(new[] { 'x' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "22":
                    try
                    {
                        serialPort.Write(new[] { 'y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "33":
                    try
                    {
                        serialPort.Write(new[] { 'z' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "T":
                    try
                    {
                        serialPort.Write(new[] {'T'}, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "R":
                    try
                    {
                        serialPort.Write(new[] { 'R' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void run_worker_completed(object sender, RunWorkerCompletedEventArgs e)
        //The updater that updates the GUI with the new info and writes to the Timestamp CSV
        {
            string reply = "";
            if (!e.Cancelled && (e.Error == null) && (e.Result != null) && SessionHasBegun)
            {
                var messageType = e.Result.ToString().Substring(0, 1);
                if (messageType == "G")
                {
                    newSesh = true;
                }
                if (newSesh)
                {
                    if (train)
                    {
                        switch (messageType)
                        {
                            case "c":
                                correctCnt++;
                                correctNum.Text = correctCnt.ToString();
                                lastMessage = "c";
                                break;

                        }
                    }
                    else
                    {
                        switch (messageType)
                        {
                            case "w":
                                startButton.ForeColor = Color.White;
                                break;
                            case "c":
                                correctCnt++;
                                correctNum.Text = correctCnt.ToString();
                                lastMessage = "c";
                                break;
                            case "i":
                                inboundCnt++;
                                inboundNum.Text = inboundCnt.ToString();
                                lastMessage = "i";
                                inboundPercentCor = Math.Round(
                                    (((correctCnt - corOut) / (inboundCnt + correctCnt - corOut)) * 100), 0,
                                    MidpointRounding.AwayFromZero);
                                inboundPercent.Text = $"{inboundPercentCor.ToString()}%";
                                nextCorrect.Text = "Feeder 2";
                                break;
                            case "o":
                                outboundCnt++;
                                outboundNum.Text = outboundCnt.ToString();
                                lastMessage = "o";
                                percentCor = Math.Round((((corOut) / (outboundCnt + corOut)) * 100), 0,
                                    MidpointRounding.AwayFromZero);
                                percentCorrect.Text = $"{percentCor.ToString()}%";
                                nextCorrect.Text = "Feeder 2";
                                break;
                            case "r":
                                repeatCnt++;
                                repeatNum.Text = repeatCnt.ToString();
                                lastMessage = "r";
                                break;
                            case "b":
                                initialCnt++;
                                initialNum.Text = initialCnt.ToString();
                                lastMessage = "b";
                                break;
                            case "1":
                                switch (lastMessage)
                                {
                                    case "c":
                                        CsvFiles.TimestampCsv.Write($"1,Correct,{DateTime.Now - startdTime}\n");

                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"1, CorrectOubound, {corOut}\" 0 0", ref reply);
                                        }


                                                corOut++;
                                        //corOutNum.Text = corOut.ToString();
                                        outbound_num_corr.Text = $"{corOut.ToString()}";
                                        percentCor = Math.Round((((corOut) / (outboundCnt + corOut)) * 100), 0,
                                            MidpointRounding.AwayFromZero);
                                        percentCorrect.Text = $"{percentCor.ToString()}%";
                                        last = 1;
                                        nextCorrect.Text = "Feeder 2";
                                        break;
                                    case "i":
                                        CsvFiles.TimestampCsv.Write($"1,Inbound Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"1, Inbound Error\" 0 0", ref reply);
                                        }
                                        last = 1;
                                        break;
                                    case "o":
                                        CsvFiles.TimestampCsv.Write($"1,Outbound Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"1, Outbound Error\" 0 0", ref reply);
                                        }
                                        last = 1;
                                        break;
                                    case "r":
                                        CsvFiles.TimestampCsv.Write($"1,Repeat Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"1, Repeat Error\" 0 0", ref reply);
                                        }
                                        break;
                                    case "b":
                                        CsvFiles.TimestampCsv.Write($"1,Initial Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"1, Initial Error\" 0 0", ref reply);
                                        }
                                        last = 1;
                                        break;
                                }

                                break;
                            case "2":
                                switch (lastMessage)
                                {
                                    case "c":
                                        CsvFiles.TimestampCsv.Write($"2,Correct,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"1, CorrectInbound, {corInb}\" 0 0", ref reply);
                                        }
                                        corInb++;
                                        if (last == 0)
                                        {
                                            nextCorrect.Text = "Feeder 1/3";
                                        }
                                        if (last == 1)
                                        {
                                            nextCorrect.Text = "Feeder 3";
                                        }
                                        if (last == 3)
                                        {
                                            nextCorrect.Text = "Feeder 1";
                                        }
                                        inbound_num_corr.Text = $"{corInb.ToString()}";
                                        inboundPercentCor = Math.Round(
                                            (((correctCnt - corOut) / (inboundCnt + correctCnt - corOut)) * 100), 0,
                                            MidpointRounding.AwayFromZero);
                                        if (inboundPercentCor == Double.PositiveInfinity)
                                        {
                                            inboundPercentCor = 100;
                                        }
                                        inboundPercent.Text = $"{inboundPercentCor.ToString()}%";
                                        break;
                                    case "i":
                                        CsvFiles.TimestampCsv.Write($"2,Inbound Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"2,Inbound Error\" 0 0", ref reply);
                                        }
                                        break;
                                    case "o":
                                        CsvFiles.TimestampCsv.Write($"2,Outbound Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"2,Outbound Error\" 0 0", ref reply);
                                        }
                                        break;
                                    case "r":
                                        CsvFiles.TimestampCsv.Write($"2,Repeat Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"2,Repeat Error\" 0 0", ref reply);
                                        }
                                        break;
                                    case "b":
                                        CsvFiles.TimestampCsv.Write($"2,Initial Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"2,Initial Error\" 0 0", ref reply);
                                        }
                                        break;
                                }

                                break;
                            case "3":
                                switch (lastMessage)
                                {
                                    case "c":
                                        CsvFiles.TimestampCsv.Write($"3,Correct,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"3, CorrectOutbound, {corOut}\" 0 0", ref reply);
                                        }
                                        corOut++;
                                        //corOutNum.Text = corOut.ToString();
                                        outbound_num_corr.Text = $"{corOut.ToString()}";
                                        percentCor = Math.Round((((corOut) / (outboundCnt + corOut)) * 100), 0,
                                            MidpointRounding.AwayFromZero);
                                        percentCorrect.Text = $"{percentCor.ToString()}%";
                                        last = 3;
                                        nextCorrect.Text = "Feeder 2";
                                        break;
                                    case "i":
                                        CsvFiles.TimestampCsv.Write($"3,Inbound Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"3,Inbound Error\" 0 0", ref reply);
                                        }
                                        last = 3;
                                        break;
                                    case "o":
                                        CsvFiles.TimestampCsv.Write($"3,Outbound Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"3,Outbound Error\" 0 0", ref reply);
                                        }
                                        last = 3;
                                        break;
                                    case "r":
                                        CsvFiles.TimestampCsv.Write($"3,Repeat Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"3,Repeat Error\" 0 0", ref reply);
                                        }
                                        break;
                                    case "b":
                                        CsvFiles.TimestampCsv.Write($"3,Initial Error,{DateTime.Now - startdTime}\n");
                                        if (recordingStatus == true)
                                        {
                                            mNetComClient.SendCommand($"-PostEvent \"3,Initial Error\" 0 0", ref reply);
                                        }
                                        last = 3;
                                        break;
                                }

                                break;

                        }
                        totes = inboundCnt + repeatCnt + initialCnt + outboundCnt;
                        totalErrNum.Text = totes.ToString();
                        totalNum.Text = (totes + correctCnt).ToString();
                    }
                }
            
        }
           
            if (!felix.IsBusy)
                felix.RunWorkerAsync();
        }

        private void acquireButton_Click(object sender, EventArgs e)
        {
            string reply = "";
            if (acquireButton.BackColor == Color.AliceBlue)
            {
                mNetComClient.SendCommand("-StopAcquisition", ref reply);
                acquireButton.BackColor = Color.FromArgb(38, 38, 38);
                recordButton.BackColor = Color.FromArgb(38, 38, 38);
            }
            else
            {
                mNetComClient.SendCommand("-StartAcquisition", ref reply);
                acquireButton.BackColor = Color.AliceBlue;
            }   
            
            
            
        }

        public void recordButton_Click(object sender, EventArgs e)
        {

            string reply = "";
            if (recordButton.BackColor == Color.AliceBlue)
            {
                mNetComClient.SendCommand("-StopRecording", ref reply);
                recordButton.BackColor = Color.FromArgb(38, 38, 38);
            }
            else
            {
                mNetComClient.SendCommand("-StartRecording", ref reply);
                recordButton.BackColor = Color.AliceBlue;

            }

        }

        public void disable_NLX()
        {
            startPreSleep.Visible = false;
            stopPreSleep.Visible = false;
            recordButton.Enabled = false;
            acquireButton.Enabled = false;
        }

        public void trainMode()
        {
            
            inboundNum.Visible = false;
            inboundPercent.Visible = false;
            initialNum.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            totalNum.Visible = false;
            nextCorrect.Visible = false;
            outboundNum.Visible = false;
            panel10.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            percentCorrect.Visible = false;
            repeatNum.Visible = false;
            Total.Visible = false;
            totalErrNum.Visible = false;
            totalIncorrect.Visible = false;
        }

        private void startPreSleep_Click(object sender, EventArgs e)
        {
            if (recordButton.BackColor != Color.AliceBlue)
            {
                MessageBox.Show(this, "Cheetah Recording", "Check if Cheetah is Recording Session", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            _elapsed_time = 0;
            Recording_Time.Enabled = true;
            updateTime();
            startPreSleep.ForeColor = Color.GhostWhite;
            startPreSleep.BackColor = Color.SeaGreen;
            string reply = "";
            //mNetComClient.SendCommand("-PostEvent \"StartSleepPre\" 0 0", ref reply);
            if (!(mNetComClient.SendCommand("-PostEvent \"StartSleepPre\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
            
        }
            
        

        private void stopPreSleep_Click(object sender, EventArgs e)
        {
            Recording_Time.Enabled = false;
            _elapsed_time = 0;
            stopPreSleep.ForeColor = Color.GhostWhite;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StopSleepPre\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void startPostSleep_Click(object sender, EventArgs e)
        {
            _elapsed_time = 0;
            Recording_Time.Enabled = true;
            updateTime();
            startPostSleep.ForeColor = Color.GhostWhite;
            startPostSleep.BackColor = Color.SeaGreen;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StartSleepPost\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void stopPostSleep_Click(object sender, EventArgs e)
        {
            Recording_Time.Enabled = false;
            stopPostSleep.ForeColor = Color.GhostWhite;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StopSleepPost\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void rat_timelabel_Click(object sender, EventArgs e)
        {

        }

        private void ephys_Click(object sender, EventArgs e)
        {
            var ephys_window = new Ephys();
            ephys_window.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}