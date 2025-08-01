namespace DiscGolf_Disc_Lookup_CLI
{
    using System;
    using System.Collections.Generic;
    using Spectre.Console;

    public class Disc_Lookup_CLI
    {
        private static readonly Style highlightStyle = new Style(new Color(0, 191, 255)); // deepskyblue2
        private static readonly Spinner spinner = AnsiConsole.Profile.Capabilities.Unicode ? Spinner.Known.Dots : Spinner.Known.Default;

        public static void Main()
        {
            OnStart_Tasks();

            int exitValue = -1;

            do
            {
                exitValue = Menu();
            } while (exitValue != 0);


            WriteAscii(true);
            Console.WriteLine("\n\n\nThank you for using the Disc Lookup tool!");

            AnsiConsole.Status()
                    .Spinner(spinner)
                    .Start("[deepskyblue2]Thank you for using the Disc Lookup tool![/]", ctx =>
                    {
                        ctx.Status = "[deepskyblue2]Exiting...[/]";
                        Thread.Sleep(2500); // Simulate some delay
                    });
        }

        private static void OnStart_Tasks()
        {
            // Ensure UTF-8 encoding for proper character display
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        private static int Menu()
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
                return 0;
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

            return -1; // -1 to indicate error
        }

        private static void AdvancedSearch()
        {
            WriteAscii(true);
            Console.WriteLine("\n\n\n");

            bool invalidEntry = false;

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

            do
            {
                if (criteria.Contains("Speed"))
                {
                    var speedStr = AnsiConsole.Ask<string>("Enter Speed ( 1 <-> 14 ):");
                    speed = double.TryParse(speedStr, out var s) ? s : (double?)null;

                    if (speed < 1 || speed > 14)
                    {
                        AnsiConsole.MarkupLine("[red]Speed must be between 1 and 14. Please try again.[/]");
                        Thread.Sleep(2500);

                        invalidEntry = true;

                        WriteAscii(true);
                        Console.WriteLine("\n\n\n");
                    }
                    else
                        invalidEntry = false; // Valid entry
                }

            } while (invalidEntry);

            do
            {
                if (criteria.Contains("Glide"))
                {
                    var glideStr = AnsiConsole.Ask<string>("Enter Glide ( 1 <-> 7 ):");
                    glide = double.TryParse(glideStr, out var g) ? g : (double?)null;

                    if (glide < 1 || glide > 7)
                    {
                        AnsiConsole.MarkupLine("[red]Glide must be between 1 and 7. Please try again.[/]");
                        Thread.Sleep(2500);

                        invalidEntry = true;

                        WriteAscii(true);
                        Console.WriteLine("\n\n\n");
                    }
                    else
                        invalidEntry = false; // Valid entry
                }

            } while (invalidEntry);


            do
            {
                if (criteria.Contains("Turn"))
                {
                    var turnStr = AnsiConsole.Ask<string>("Enter Turn ( +1 <-> -5):");
                    turn = double.TryParse(turnStr, out var t) ? t : (double?)null;

                    if (turn > 1 || turn < -5)
                    {
                        AnsiConsole.MarkupLine("[red]Turn must be between +1 and -5. Please try again.[/]");
                        Thread.Sleep(2500);

                        invalidEntry = true;

                        WriteAscii(true);
                        Console.WriteLine("\n\n\n");
                    }
                    else
                        invalidEntry = false; // Valid entry
                }

            } while (invalidEntry);

            do
            {
                if (criteria.Contains("Fade"))
                {
                    var fadeStr = AnsiConsole.Ask<string>("Enter Fade ( 0 <-> 5):");
                    fade = double.TryParse(fadeStr, out var f) ? f : (double?)null;

                    if (fade < 0 || fade > 5)
                    {
                        AnsiConsole.MarkupLine("[red]Fade must be between 0 and 5. Please try again.[/]");
                        Thread.Sleep(2500);

                        invalidEntry = true;
                        
                        WriteAscii(true);
                        Console.WriteLine("\n\n\n");
                    }
                    else
                        invalidEntry = false; // Valid entry
                }

            } while (invalidEntry);


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
                Thread.Sleep(2500);
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
                        "Mid Range",
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

            if (string.IsNullOrEmpty(name))
            {
                //AnsiConsole.MarkupLine("[red]No name entered. Returning to main menu.[/]");

                AnsiConsole.Status()
                    .Spinner(spinner)
                    .Start("[red]No name entered. Returning to main menu.[/]", ctx =>
                    {
                        Thread.Sleep(2500); // Simulate some delay
                    });

                return;
            }

            // All disc names are stored in Title Case, so we need to ensure the first letter is uppercase
            if (name.Substring(0, 1).ToLower() == name.Substring(0, 1))
                name = name.Replace(name.Substring(0, 1), name.Substring(0, 1).ToUpper());

            DiscGolfDisc disc = DiscList.GetDiscByName(name);

            if (disc == null) {
                AnsiConsole.Status()
                    .Spinner(spinner)
                    .Start($"No disc found with the name '[underline bold red]{name}[/]'. Returning to main menu.", ctx =>
                    {
                        Thread.Sleep(4500); // Simulate some delay
                    });

                return;
            }

            List<DiscGolfDisc> discs = new List<DiscGolfDisc>();
            discs.Add(disc);

            WriteTable(discs);
        }

        private static void WriteTable(List<DiscGolfDisc> list)
        {
            WriteAscii(true);

            Console.WriteLine("\n\n\n");

            var table = new Table
            {
                Border = TableBorder.Rounded,
                Title = new TableTitle("[bold]Disc Golf Discs[/]", highlightStyle),
                ShowRowSeparators = true,
            };

            AnsiConsole.Live(table)
                .Start(ctx =>
                {
                    table.AddColumn(new TableColumn("[underline bold]Name[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    table.AddColumn(new TableColumn("[underline bold]Brand[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    table.AddColumn(new TableColumn("[underline bold]Type[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    table.AddColumn(new TableColumn("[underline bold]Speed[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    table.AddColumn(new TableColumn("[underline bold]Glide[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    table.AddColumn(new TableColumn("[underline bold]Turn[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    table.AddColumn(new TableColumn("[underline bold]Fade[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(100); // Simulate loading delay

                    foreach (DiscGolfDisc disc in list)
                    {
                        table.AddRow(disc.Name, disc.Brand, disc.Type, "[deepskyblue2]" + disc.Speed.ToString() + "[/]", "[green]" + disc.Glide.ToString() + "[/]",
                            "[purple]" + disc.Turn.ToString() + "[/]", "[red]" + disc.Fade.ToString() + "[/]");

                        ctx.Refresh();

                        if (list.Count() > 10)
                            Thread.Sleep(25);
                        else
                            Thread.Sleep(150); // Simulate loading delay
                    }

                });

            AnsiConsole.Markup("\n\n\n[grey]Press any key to return to the main menu...[/]");
            Console.ReadKey(); // Wait for user input before returning to the main menu
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