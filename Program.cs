using System;
namespace Table
{
    class Program
    {
        static void Main()
        {
            Table table = new Table(50,ConsoleColor.Gray,ConsoleColor.Black);
            table.AddRow("Title 1", "Title 2", "Title 3", "Title n" /*....... args*/);
            table.AddRow("Title 1", "Title 2", "Title 3", "Title n");
            table.AddRow("Title 1", "Title 2", "Title 3", "Title n");
            table.AddRow("Title 1", "Title 2", "Title 3", "Title n");
            table.AddRow("Title 1", "Title 2", "Title 3", "Title n");
            table.AddRow("Title 1", "Title 2", "Title 3", "Title n");
            Console.ReadKey();
        }
    }
}
