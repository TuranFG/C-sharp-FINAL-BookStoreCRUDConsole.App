using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.Helpers
{
    public static partial class Helper
    {
        public static T ReadMenu<T>(string caption)
            where T: Enum
        {
            var menu = Enum.GetValues(typeof(T));
            foreach (var item in menu)
            {
               
                Type utype = Enum.GetUnderlyingType(typeof(T));
                var id = Convert.ChangeType(item, utype);
                Console.WriteLine($"{id.ToString().PadLeft(2, ' ')}. {item}");
            }
            string income;
        label1:
            ConsoleColor oldcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(caption);
            Console.ForegroundColor = oldcolor;
            income = Console.ReadLine();
            if (!Enum.TryParse(typeof(T), income, out object value) || !Enum.IsDefined(typeof(T), value))
            {
                goto label1;
            }
            return (T)value;

        }
    }
}
