namespace DiscGolf_Disc_Lookup_CLI
{
    using System;
    using System.Collections.Generic;
    using Spectre.Console;

    public class Disc_Lookup_CLI
    {
        private static readonly Style highlightStyle = new Style(new Color(0, 191, 255)); // deepskyblue2

        public static void Main()
        {
            Menu();

            Console.ReadKey(); // Wait for user input before closing
        }

        private static void Menu()
        {
            WriteAscii(true);

            Console.WriteLine("\n\n\n");

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Please select an option")
                .PageSize(5)
                .HighlightStyle(highlightStyle)
                .AddChoices(
                    new[]
                    {
                        "Get Disc by NAME",
                        "Get Discs by BRAND",
                        "Get Discs by TYPE",
                        "Advanced Search",
                        "Exit"
                    }));

            if (selection == "Exit")
                Environment.Exit(0);
            else if (selection == "Get Disc by NAME")
                GetByName();
            else if (selection == "Get Discs by BRAND")
                GetByBrand();
            else if (selection == "Get Discs by TYPE")
                GetByType();
            else if (selection == "Advanced Search")
                AdvancedSearch();
            else
                AnsiConsole.MarkupLine("[red]Invalid selection. Please try again.[/]");
        }

        private static void AdvancedSearch()
        {
            WriteAscii(true);
            Console.WriteLine("\n\n\n");

            var criteria = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                    .Title("Select search criteria")
                    .PageSize(6)
                    .HighlightStyle(highlightStyle)
                    .InstructionsText("[grey](Press [blue]<space>[/] to toggle, [green]<enter>[/] to submit)[/]")
                    .AddChoices(
                        new[]
                        {
                            "Type",
                            "Speed",
                            "Glide",
                            "Turn",
                            "Fade",
                            "Brand"
                        }));

            if (criteria.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]No criteria selected. Returning to main menu.[/]");
                return;
            }

            string type = null, brand = null;
            double? speed = null, glide = null, turn = null, fade = null;

            if (criteria.Contains("Type"))
            {
                type = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select disc type (or leave blank for any)")
                        .PageSize(4)
                        .HighlightStyle(highlightStyle)
                        .AddChoices(
                            new[]
                            {
                                "Distance Driver",
                                "Fairway Driver",
                                "Mid Range",
                                "Putt & Approach",
                            }));
                if (string.IsNullOrEmpty(type)) type = null;
            }

            if (criteria.Contains("Speed"))
            {
                var speedStr = AnsiConsole.Ask<string>("Enter Speed (or leave blank for any):");
                speed = double.TryParse(speedStr, out var s) ? s : (double?)null;
            }

            if (criteria.Contains("Glide"))
            {
                var glideStr = AnsiConsole.Ask<string>("Enter Glide (or leave blank for any):");
                glide = double.TryParse(glideStr, out var g) ? g : (double?)null;
            }

            if (criteria.Contains("Turn"))
            {
                var turnStr = AnsiConsole.Ask<string>("Enter Turn (or leave blank for any):");
                turn = double.TryParse(turnStr, out var t) ? t : (double?)null;
            }

            if (criteria.Contains("Fade"))
            {
                var fadeStr = AnsiConsole.Ask<string>("Enter Fade (or leave blank for any):");
                fade = double.TryParse(fadeStr, out var f) ? f : (double?)null;
            }

            if (criteria.Contains("Brand"))
            {
                AnsiConsole.MarkupLine("[grey]Available brands:[/]");
                brand = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Please select a brand")
                .PageSize(10)
                .HighlightStyle(highlightStyle)
                .AddChoices(
                    new[]
                    {
                        "Axiom Discs", "Clash Discs", "DGA", "Discmania", "Discraft", "Dynamic Discs",
                        "Gateway", "Innova", "Kastaplast", "Latitude 64", "Millenium", "Mint", "MVP",
                        "Prodigy", "RPM", "Streamline", "Thought Space Athletics", "Westside Discs", "Yikun"
                    }));

                if (string.IsNullOrWhiteSpace(brand)) brand = null;
            }

            try
            {
                var discs = DiscList.GetDiscsByMultipleCriteria(type, speed, fade, glide, turn, brand);
                WriteTable(discs);
            }
            catch (KeyNotFoundException ex)
            {
                WriteAscii(true);
                AnsiConsole.MarkupLine($"[red]{ex.Message}[/]");
            }
        }

        private static void GetByType()
        {
            WriteAscii(true);

            Console.WriteLine("\n\n\n");

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Please select a disc type")
                .PageSize(4)
                .HighlightStyle(highlightStyle)
                .AddChoices(
                    new[]
                    {
                        "Distance Driver",
                        "Fairway Driver",
                        "Midrange",
                        "Putt & Approach"
                    }));

            List<DiscGolfDisc> disc = new List<DiscGolfDisc>();

            disc = DiscList.GetDiscsByType(selection);

            if (disc.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]No discs found for the selected type.[/]");
            }
            else
            {
                WriteTable(disc);
            }
        }

        private static void GetByBrand()
        {
            WriteAscii(true);

            Console.WriteLine("\n\n\n");

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Please select a brand")
                .PageSize(10)
                .HighlightStyle(highlightStyle)
                .AddChoices(
                    new[]
                    {
                        "Axiom Discs", "Clash Discs", "DGA", "Discmania", "Discraft", "Dynamic Discs",
                        "Gateway", "Innova", "Kastaplast", "Latitude 64", "Millenium", "Mint", "MVP",
                        "Prodigy", "RPM", "Streamline", "Thought Space Athletics", "Westside Discs", "Yikun"
                    }));

            List<DiscGolfDisc> disc = new List<DiscGolfDisc>();

            disc = DiscList.GetDiscsByBrand(selection);

            if (disc.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]No discs found for the selected brand.[/]");
            }
            else
            {
                WriteTable(disc);
            }
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