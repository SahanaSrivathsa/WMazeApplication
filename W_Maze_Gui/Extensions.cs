using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace W_Maze_Gui
{
    static class Extensions
    {
        public static byte[] ToBytes(this string message)
        {
            return Encoding.UTF8.GetBytes(message);
        }
        public static string EnumerableToString<T>(this IEnumerable<T> message)
        {
            string result = "";
            foreach (var elem in message)
            {
                result += elem;
            }
            return result;
        }

        public static string ToAnsii(this byte[] byteMessage)
        {
            return Encoding.Default.GetString(byteMessage);
        }
    }
}
