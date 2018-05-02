using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace W_Maze_Gui
{
    public static class FormConsole
    {
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;
        private static StreamWriter _standardOutput;

        [DllImport("kernel32.dll",
            EntryPoint = "GetStdHandle",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();

        public static void configureConsole()
        {
            AllocConsole();
            var stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            var safeFileHandle = new SafeFileHandle(stdHandle, true);
            var fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            var encoding = Encoding.GetEncoding(MY_CODE_PAGE);
            _standardOutput = new StreamWriter(fileStream, encoding);
            var standardOutput = _standardOutput;
            standardOutput.AutoFlush = true;
        }
    }
}