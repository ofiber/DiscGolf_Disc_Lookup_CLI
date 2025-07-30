namespace DiscGolf_Disc_Lookup_CLI
{
    using System;
    using System.Collections.Generic;
    using Spectre.Console;

    public class Disc_Lookup_CLI
    {
        private static readonly Style highlightStyle = new Style(new Color(0, 191, 255)); // deepskyblue2
        private static readonly List<DiscGolfDisc> discs = DiscList.Discs; // Fixed: Accessing static member directly with the class name

        public static void Main()
        {
            Menu();
        }

        private static void Menu()
        {
            WriteAscii(true);

            Console.WriteLine("\n\n\n");

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Please select an option")
                .PageSize(3)
                .HighlightStyle(highlightStyle)
                .AddChoices(
                    new[]
                    {
                        "Get Disc by NAME",
                        "Get Discs by BRAND",
                        "Exit"
                    }));

            if (selection == "Exit")
                Environment.Exit(0);
            else if (selection == "Get Disc by NAME")
                GetByName();
            else if (selection == "Get Discs by BRAND")
                GetByBrand();
                
        }

        private static void GetByBrand()
        {
            AnsiConsole.Write("\n\nEnter a disc brand: ");
            string brand = Console.ReadLine();

            List<DiscGolfDisc> disc = DiscList.GetDiscsByBrand(brand);

            WriteTable(disc);
        }

        private static void GetByName()
        {
            AnsiConsole.Write("\n\nEnter a disc name: ");
            string name = Console.ReadLine();

            List<DiscGolfDisc> disc = new List<DiscGolfDisc>();
            disc.Add(DiscList.GetDiscByName(name));

            WriteTable(disc);
        }

        private static void WriteTable(List<DiscGolfDisc> list)
        {
            WriteAscii(true);

            Console.WriteLine("\n\n\n\n");

            var table = new Table
            {
                Border = TableBorder.Rounded,
                Title = new TableTitle("[bold]Disc Golf Discs[/]", highlightStyle),
                ShowRowSeparators = true,
            };

            table.AddColumn(new TableColumn("[underline bold]Name[/]").Centered());
            table.AddColumn(new TableColumn("[underline bold]Brand[/]").Centered());
            table.AddColumn(new TableColumn("[underline bold]Type[/]").Centered());
            table.AddColumn(new TableColumn("[underline bold]Speed[/]").Centered());
            table.AddColumn(new TableColumn("[underline bold]Glide[/]").Centered());
            table.AddColumn(new TableColumn("[underline bold]Turn[/]").Centered());
            table.AddColumn(new TableColumn("[underline bold]Fade[/]").Centered());

            foreach (DiscGolfDisc disc in list)
            {
                table.AddRow(disc.Name, disc.Brand, disc.Type, "[blue]" + disc.Speed.ToString() + "[/]", "[green]" + disc.Glide.ToString() + "[/]",
                    "[purple]" + disc.Turn.ToString() + "[/]", "[red]" + disc.Fade.ToString() + "[/]");
            }

            AnsiConsole.Write(table);
        }

        private static void WriteAscii(bool clear)
        {
            if (clear)
                Console.Clear();

            AnsiConsole.MarkupLine("[deepskyblue2]\r\n\r\n██████╗ ██╗███████╗██╗  ██╗    ███████╗██╗███╗   ██╗██████╗ ███████╗██████╗ " +
                                                 "\r\n██╔══██╗██║██╔════╝██║ ██╔╝    ██╔════╝██║████╗  ██║██╔══██╗██╔════╝██╔══██╗ " +
                                                 "\r\n██║  ██║██║███████╗█████╔╝     █████╗  ██║██╔██╗ ██║██║  ██║█████╗  ██████╔╝ " +
                                                 "\r\n██║  ██║██║╚════██║██╔═██╗     ██╔══╝  ██║██║╚██╗██║██║  ██║██╔══╝  ██╔══██╗ " +
                                                 "\r\n██████╔╝██║███████║██║  ██╗    ██║     ██║██║ ╚████║██████╔╝███████╗██║  ██║ " +
                                                 "\r\n╚═════╝ ╚═╝╚══════╝╚═╝  ╚═╝    ╚═╝     ╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝  ╚═╝ [/]");
        }
    }
}