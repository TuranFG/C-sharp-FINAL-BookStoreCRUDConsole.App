using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.Helpers
{
    public static partial class Helper
    {
        public static string ReadString (string caption, bool IsNullOrEmpty = false)
        {
            string income;
        label1:
            ConsoleColor oldcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(caption);
            Console.ForegroundColor = oldcolor;
            income = Console.ReadLine();
            if (IsNullOrEmpty == false && string.IsNullOrWhiteSpace(income))
            {
                goto label1;
            }
            return income;
        }
    }
}
