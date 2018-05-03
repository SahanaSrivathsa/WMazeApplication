using System.IO;

namespace W_Maze_Gui
{
    public static class CsvFiles
    {
        public static StreamWriter SessionCsv;
        public static StreamWriter TimestampCsv;
        public static StreamReader RatdataReader;
        public static StreamWriter RatdataWriter;
        public static StreamWriter initial;
        public static StreamWriter trainingCsv;
        private const string RatDataPath = @"C:\Users\akoutia\Documents\Barnes Lab\Wmaze\RatData\RatData.Csv";
        private const string RatDirectoryPath = @"C:\Users\akoutia\Documents\Barnes Lab\Wmaze\RatData\";
        private const string trainingPath = @"C:\Users\akoutia\Documents\Barnes Lab\Wmaze\RatData\Training\";
        public static void OpenRatDataCsv()
        {
            //ratdataReader = new StreamReader("RatData.csv",true);

            RatdataReader = new StreamReader(RatDataPath);
        }

        public static void OpenWriteToRatData()
        {
            RatdataWriter = new StreamWriter(RatDataPath);
        }

        public static void CloseRatDataCsv()
        {
            RatdataReader.Close();
        }

        public static void OpenTrainingCsv(string number)
        {
            if (!Directory.Exists(trainingPath + number))
            {
                Directory.CreateDirectory(trainingPath + number);
                trainingCsv = new StreamWriter(trainingPath + number + $@"\{number}_training.csv");
                trainingCsv.Write("Day/Time,Experimenter,Session Length,Laps,Notes\n");
                trainingCsv.Close();
            }
            trainingCsv = new StreamWriter(trainingPath + number + $@"\{number}_training.csv",true);
        }

        public static void OpenSessionCsv(string number)
        {
            if (!Directory.Exists(RatDirectoryPath + number))
            {
                Directory.CreateDirectory(RatDirectoryPath + number);
                initial =
                    new StreamWriter(
                        RatDirectoryPath + number + $@"\SessionInfo_{number}.csv",
                        true);
                initial.Write("Session,Experimenter,Day/Time,Session Length,Correct,Correct Outbound,Initial Error,Outbound Errors,Inbound Errors,Repeat Errors,Total Errors,Total Feeder Visits,Notes\n");
                initial.Close();
            }

                SessionCsv =
                    new StreamWriter(
                        RatDirectoryPath + number + $@"\SessionInfo_{number}.csv",
                        true);
           
        }

        public static void OpenTimestampCsv(string number, string session)
        {
            if (!Directory.Exists($@"C:\Users\akoutia\Documents\Barnes Lab\Wmaze\RatData\{number}\TimeStamps"))
                Directory.CreateDirectory(
                    $"C:\\Users\\akoutia\\Documents\\Barnes Lab\\Wmaze\\RatData\\{number}\\TimeStamps");
            TimestampCsv =
                new StreamWriter(
                    $"C:\\Users\\akoutia\\Documents\\Barnes Lab\\Wmaze\\RatData\\{number}\\TimeStamps\\TimeStamps_{number}_Session{session}.csv");
        }

        public static void Close()
        {
            TimestampCsv.Close();
            SessionCsv.Close();
        }

        public static void RatdataClose()
        {
            RatdataWriter.Close();
        }
    }
}