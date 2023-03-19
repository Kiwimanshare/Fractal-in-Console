﻿namespace Fractal
{
    class Program
    {
        private static string[] menuOptions = new string[]
        {
            "1 -              Mandelbrot Set",
            "2 -                   Julia Set",
            "3 -                Burning Ship",
            "4 - Create custom color palette",
            "5 -              Show Controlls",
            "6 -                        Exit"
        };

        private static string[] fractalControllerControls = new string[]
        {
            "Controls:",
            "Arrow keys:    Move cursor",
            "Space bar:     Change color palette",
            "X:             Zoom in",
            "Y:             Zoom out",
            "Enter:         Center view",
            "1:             Show Mandelbrot set",
            "2:             Show Julia set",
            "3:             Show Burning Ship",
            "ESC:           Back to Menu",
            "Ctrl+C:        Exit program"
        };

        static void Main(string[] args)
        {
            int width = 180;
            int height = 60;

            Console.WriteLine("Enter desired width of window (Min: 1, Max: {0})", Console.LargestWindowWidth);
            string inputWidth = Console.ReadLine();
            if (!int.TryParse(inputWidth, out width) || width < 1 || width > Console.LargestWindowWidth)
            {
                width = 180;
            }

            Console.WriteLine("Enter desired height of window (Min: 1, Max: {0}))", Console.LargestWindowHeight);
            string inputHeight = Console.ReadLine();
            if (!int.TryParse(inputHeight, out height) || height < 1 || height > Console.LargestWindowHeight)
            {
                height = 60;
            }

            Console.WindowWidth = width;
            Console.WindowHeight = height + 1;

            FractalTyps selectedFractal = FractalTyps.MandelbrotSet;
            List<ColorPalette> colorPalettes = ColorPalettBuilder.BuildColorPalette();

            int option = 0;
            bool displayFractal = false;

            while (true)
            {
                option = ShowMenu(width, height, "Main menu", menuOptions, option);

                switch (option)
                {
                    case 0:
                        selectedFractal = FractalTyps.MandelbrotSet;
                        displayFractal = true;
                        break;
                    case 1:
                        selectedFractal = FractalTyps.JuliaSet;
                        displayFractal = true;
                        break;
                    case 2:
                        selectedFractal = FractalTyps.BurningShip;
                        displayFractal = true;
                        break;
                    case 3:
                        ColorPalette newPalette = ColorPalettBuilder.CreateCustomPalette();
                        colorPalettes.Add(newPalette);
                        break;
                    case 4:
                        ShowInfos(width, height, fractalControllerControls);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

                if (displayFractal)
                {
                    displayFractal = false;
                    FractalController fc = new FractalController(width, height, selectedFractal, colorPalettes);
                    fc.Run();
                }
            }
        }

        static int ShowMenu(int width, int height, string title, string[] options, int currentOption = 0)
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine(title.PadLeft(width / 2 + title.Length / 2));
            Console.WriteLine(new string('-', width));

            int cursorTop = Console.CursorTop;
            int cursorLeft = Console.CursorLeft;

            for (int i = 0; i < options.Length; i++)
            {
                Console.SetCursorPosition(cursorLeft, cursorTop + i + 2);
                Console.Write(options[i].PadLeft(width / 2 + options[i].Length / 2));
            }

            Console.SetCursorPosition(cursorLeft, cursorTop + currentOption + 2);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(options[currentOption].PadLeft(width / 2 + options[currentOption].Length / 2));
            Console.ResetColor();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow && currentOption > 0)
                {
                    Console.SetCursorPosition(cursorLeft, cursorTop + currentOption + 2);
                    Console.Write(options[currentOption].PadLeft(width / 2 + options[currentOption].Length / 2));

                    currentOption--;

                    Console.SetCursorPosition(cursorLeft, cursorTop + currentOption + 2);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(options[currentOption].PadLeft(width / 2 + options[currentOption].Length / 2));
                    Console.ResetColor();
                }

                if (keyInfo.Key == ConsoleKey.DownArrow && currentOption < options.Length - 1)
                {
                    Console.SetCursorPosition(cursorLeft, cursorTop + currentOption + 2);
                    Console.Write(options[currentOption].PadLeft(width / 2 + options[currentOption].Length / 2));

                    currentOption++;

                    Console.SetCursorPosition(cursorLeft, cursorTop + currentOption + 2);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(options[currentOption].PadLeft(width / 2 + options[currentOption].Length / 2));
                    Console.ResetColor();
                }

                if (keyInfo.Key == ConsoleKey.Spacebar || keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.CursorVisible = true;
                    return currentOption;
                }

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.CursorVisible = true;
                    return 0;
                }
            }
        }

        static void ShowInfos(int windowWidth, int windowHeight, string[] options)
        {
            Console.Clear();

            // Breite und Höhe des Menüs berechnen
            int menuWidth = options.Max(o => o.Length) + 4;
            int menuHeight = options.Length + 4;

            // Position des Menüs berechnen
            int left = (windowWidth - menuWidth) / 2;
            int top = (windowHeight - menuHeight) / 2;

            // Menürahmen zeichnen
            Console.SetCursorPosition(left, top);
            Console.Write("╔" + new string('═', menuWidth - 2) + "╗");
            for (int i = 1; i < menuHeight - 1; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("║");
                Console.SetCursorPosition(left + menuWidth - 1, top + i);
                Console.Write("║");
            }
            Console.SetCursorPosition(left, top + menuHeight - 1);
            Console.Write("╚" + new string('═', menuWidth - 2) + "╝");

            // Menüoptionen schreiben
            for (int i = 0; i < options.Length; i++)
            {
                Console.SetCursorPosition(left + 2, top + i + 2);
                Console.Write(options[i]);
            }

            // Cursor positionieren
            Console.SetCursorPosition(left + 2, top + options.Length + 2);

            // Menü anzeigen
            Console.CursorVisible = false;
            Console.Read();
        }
    }
}
