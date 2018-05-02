using System.IO;

namespace Reciever
{
    internal class Logger
    {
        private static Logger _logger;
        private string DirectoryPath { get; } = @"c:\temp\";
        private string FileName { get; } = "Sender.log";
        private string FullPath { get; }
        public static Logger Instance => _logger ?? (_logger = new Logger());

        private Logger()
        {
            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);

            FullPath = DirectoryPath + FileName;
        }

        public void WriteMessage(string message)
        {
            using (var w = new StreamWriter(FullPath, true))
            {
                w.WriteLine(message);
            }
        }
    }
}