using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Table
    {
        readonly int tableWidth;
        readonly ConsoleColor ForeGround;
        readonly ConsoleColor BackGround;
        public Table(int tableWidth, ConsoleColor BackGround = ConsoleColor.Black, ConsoleColor ForeGround = ConsoleColor.White)
        {
            this.tableWidth = tableWidth;
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
        }
        public void PrintLine()
        {
            Console.BackgroundColor = BackGround;
            Console.ForegroundColor = ForeGround;
            Console.WriteLine(new string('-', tableWidth));
            Console.ResetColor();
        }
        public void AddRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.BackgroundColor = BackGround;
            Console.ForegroundColor = ForeGround;
            Console.WriteLine(row);
            Console.ResetColor();
        }
        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}