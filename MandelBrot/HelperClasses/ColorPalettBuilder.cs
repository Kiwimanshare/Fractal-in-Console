namespace Fractal
{
    public static class ColorPalettBuilder
    {
        public static List<ColorPalette> BuildColorPalette()
        {
            var palette = new List<ColorPalette>
            {
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkBlue,   ConsoleColor.Black, '■'),
                    new ColorChar(ConsoleColor.DarkGreen,  ConsoleColor.Black, '▲'),
                    new ColorChar(ConsoleColor.DarkCyan,   ConsoleColor.Black, '▼'),
                    new ColorChar(ConsoleColor.DarkMagenta,ConsoleColor.Black, '◄'),
                    new ColorChar(ConsoleColor.DarkYellow, ConsoleColor.Black, '►'),
                    new ColorChar(ConsoleColor.Blue,       ConsoleColor.Black, '●'),
                    new ColorChar(ConsoleColor.Green,      ConsoleColor.Black, '♦'),
                    new ColorChar(ConsoleColor.Cyan,       ConsoleColor.Black, '♣'),
                    new ColorChar(ConsoleColor.Magenta,    ConsoleColor.Black, '♥'),
                    new ColorChar(ConsoleColor.Yellow,     ConsoleColor.Black, '♠')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    // Die ursprüngliche Farbpalette
                    new ColorChar(ConsoleColor.DarkBlue,   ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Blue,       ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Cyan,       ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Green,      ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.Yellow,     ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.Red,        ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.DarkRed,    ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.DarkMagenta,ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    // Eine alternative Farbpalette
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.DarkRed,     ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Red,         ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Yellow,      ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.Green,       ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.Cyan,        ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.Blue,        ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.DarkBlue,    ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkCyan,    ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Cyan,        ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.DarkGreen,   ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Green,       ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkYellow,  ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.Yellow,      ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Magenta,     ConsoleColor.Black, '#'),
                    new ColorChar(ConsoleColor.DarkBlue,    ConsoleColor.Black, '&'),
                    new ColorChar(ConsoleColor.Blue,        ConsoleColor.Black, '!'),
                    new ColorChar(ConsoleColor.DarkRed,     ConsoleColor.Black, '?'),
                    new ColorChar(ConsoleColor.Red,         ConsoleColor.Black, '/'),
                    new ColorChar(ConsoleColor.DarkGray,    ConsoleColor.Black, '|'),
                    new ColorChar(ConsoleColor.Gray,        ConsoleColor.Black, '<'),
                    new ColorChar(ConsoleColor.White,       ConsoleColor.Black, '>'),
                    new ColorChar(ConsoleColor.Black,       ConsoleColor.Black, '=')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.Black,       ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.DarkBlue,    ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.DarkGreen,   ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.DarkCyan,    ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkRed,     ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.DarkYellow,  ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Gray,        ConsoleColor.Black, '#'),
                    new ColorChar(ConsoleColor.DarkGray,    ConsoleColor.Black, '&'),
                    new ColorChar(ConsoleColor.Blue,        ConsoleColor.Black, '!'),
                    new ColorChar(ConsoleColor.Green,       ConsoleColor.Black, '?'),
                    new ColorChar(ConsoleColor.Cyan,        ConsoleColor.Black, '/'),
                    new ColorChar(ConsoleColor.Red,         ConsoleColor.Black, '|'),
                    new ColorChar(ConsoleColor.Magenta,     ConsoleColor.Black, '<'),
                    new ColorChar(ConsoleColor.Yellow,      ConsoleColor.Black, '>'),
                    new ColorChar(ConsoleColor.White,       ConsoleColor.Black, '=')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.Red,         ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Yellow,      ConsoleColor.Blue, ':'),
                    new ColorChar(ConsoleColor.Green,       ConsoleColor.DarkYellow, '+'),
                    new ColorChar(ConsoleColor.Cyan,        ConsoleColor.DarkCyan, '*'),
                    new ColorChar(ConsoleColor.Magenta,     ConsoleColor.DarkMagenta, 'X'),
                    new ColorChar(ConsoleColor.Blue,        ConsoleColor.DarkBlue, '%'),
                    new ColorChar(ConsoleColor.DarkGreen,   ConsoleColor.Gray, '@'),
                    new ColorChar(ConsoleColor.DarkRed,     ConsoleColor.DarkGray, '#'),
                    new ColorChar(ConsoleColor.DarkYellow,  ConsoleColor.White, '&'),
                    new ColorChar(ConsoleColor.DarkCyan,    ConsoleColor.Red, '!'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Green, '?'),
                    new ColorChar(ConsoleColor.Gray,        ConsoleColor.Yellow, '/'),
                    new ColorChar(ConsoleColor.DarkGray,    ConsoleColor.Cyan, '|'),
                    new ColorChar(ConsoleColor.White,       ConsoleColor.Magenta, '<'),
                    new ColorChar(ConsoleColor.Black,       ConsoleColor.DarkGreen, '>'),
                    new ColorChar(ConsoleColor.Blue,        ConsoleColor.DarkRed, '=')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkRed, ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Red, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkCyan, ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.DarkBlue, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.Blue, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Magenta, ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.DarkRed, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.DarkGreen, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkCyan, ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.DarkBlue, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Gray, ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkCyan, ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.DarkGreen, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkYellow, ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Magenta, ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkRed, ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Red, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkCyan, ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.DarkBlue, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Gray, ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.Red, ConsoleColor.Black, '.'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, 'X'),
                    new ColorChar(ConsoleColor.Blue, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.DarkGreen, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.Magenta, ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.Red, ConsoleColor.Black, '%'),
                    new ColorChar(ConsoleColor.Magenta, ConsoleColor.Black, '#'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.Blue, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.DarkYellow, ConsoleColor.Black, '$'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '@'),
                    new ColorChar(ConsoleColor.DarkCyan, ConsoleColor.Black, '&'),
                    new ColorChar(ConsoleColor.DarkRed, ConsoleColor.Black, '!'),
                    new ColorChar(ConsoleColor.DarkGreen, ConsoleColor.Black, '^'),
                    new ColorChar(ConsoleColor.Gray, ConsoleColor.Black, '+'),
                    new ColorChar(ConsoleColor.White, ConsoleColor.Black, '#')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkBlue, ConsoleColor.Black, '\u2588'),
                    new ColorChar(ConsoleColor.Blue, ConsoleColor.Black, '\u2593'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, '\u2592'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '\u2580'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '\u2591'),
                    new ColorChar(ConsoleColor.Red, ConsoleColor.Black, '\u2590'),
                    new ColorChar(ConsoleColor.DarkRed, ConsoleColor.Black, '\u258C'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '\u2584')
                }),
                new ColorPalette(new List<ColorChar>
                {
                    new ColorChar(ConsoleColor.DarkBlue, ConsoleColor.Black, '·'),
                    new ColorChar(ConsoleColor.Blue, ConsoleColor.Black, ':'),
                    new ColorChar(ConsoleColor.Cyan, ConsoleColor.Black, '≈'),
                    new ColorChar(ConsoleColor.Green, ConsoleColor.Black, '*'),
                    new ColorChar(ConsoleColor.Yellow, ConsoleColor.Black, '█'),
                    new ColorChar(ConsoleColor.Red, ConsoleColor.Black, '▓'),
                    new ColorChar(ConsoleColor.DarkRed, ConsoleColor.Black, '#'),
                    new ColorChar(ConsoleColor.DarkMagenta, ConsoleColor.Black, '@')
                }),
                GetRandomPalette(),
                OtherRandomChars()
            };

            palette.Add(GenerateAveragePalette(palette));
            return palette;
        }

        public static ColorPalette GetRandomPalette()
        {
            var random = new Random();

            var colorChars = new List<ColorChar>();
            for (int i = 0; i < 8; i++)
            {
                var foregroundColor = (ConsoleColor)random.Next(0, 16);
                var backgroundColor = ConsoleColor.Black;
                char character;
                switch (random.Next(0, 5))
                {
                    case 0:
                        character = '░';
                        break;
                    case 1:
                        character = '▒';
                        break;
                    case 2:
                        character = '▓';
                        break;
                    case 3:
                        character = '■';
                        break;
                    default:
                        character = '□';
                        break;
                }
                colorChars.Add(new ColorChar(foregroundColor, backgroundColor, character));
            }

            return new ColorPalette(colorChars);
        }

        public static ColorPalette OtherRandomChars()
        {
            var random = new Random(42);

            return new ColorPalette(new List<ColorChar>
            {
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128)),
                new ColorChar((ConsoleColor)random.Next(16), (ConsoleColor)random.Next(16), (char)random.Next(128))
            });
        }

        public static ColorPalette GenerateAveragePalette(List<ColorPalette> palettes)
        {
            // calculate average number of colors
            int totalColors = palettes.Sum(p => p.ColorChars.Count);
            int averageColors = totalColors / palettes.Count;

            // get all characters used in palettes
            List<char> usedChars = palettes.SelectMany(p => p.ColorChars.Select(c => c.Character)).Distinct().ToList();

            // pick colors for characters
            List<ColorChar> colorChars = new List<ColorChar>();
            foreach (char c in usedChars)
            {
                // get colors used for this character
                List<ConsoleColor> usedFgColors = palettes.SelectMany(p => p.ColorChars.Where(cc => cc.Character == c).Select(cc => cc.ForegroundColor)).ToList();
                List<ConsoleColor> usedBgColors = palettes.SelectMany(p => p.ColorChars.Where(cc => cc.Character == c).Select(cc => cc.BackgroundColor)).ToList();

                // pick random color for this character
                ConsoleColor fgColor = usedFgColors.Count == 0 ? ConsoleColor.White : usedFgColors.GroupBy(x => x)
                                                                                         .OrderByDescending(x => x.Count())
                                                                                         .Select(x => x.Key)
                                                                                         .First();

                ConsoleColor bgColor = usedBgColors.Count == 0 ? ConsoleColor.Black : usedBgColors.GroupBy(x => x)
                                                                                                  .OrderByDescending(x => x.Count())
                                                                                                  .Select(x => x.Key)
                                                                                                  .First();

                // add new colorchar to list
                colorChars.Add(new ColorChar(fgColor, bgColor, c));
            }

            // pick subset of colors to use
            List<ColorChar> finalColors = colorChars.Take(averageColors).ToList();

            // return new palette
            return new ColorPalette(finalColors);
        }

        public static ColorPalette CreateCustomPalette()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("Create your own color palette");
            Console.WriteLine("Use arrow keys to select color and character, then press Enter to continue:");
            Console.WriteLine();

            // Verfügbare Farben
            ConsoleColor[] availableColors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            ConsoleColor selectedForegroundColor = availableColors[0];
            ConsoleColor selectedBackgroundColor = availableColors[0];

            // Verfügbare Zeichen
            char[] availableCharacters = new char[] { '.', ':', '+', '*', 'X', '%', '@', '#', '&', '!', '?', '/', '|', '<', '>', '=' };
            char selectedCharacter = availableCharacters[0];

            List<ColorChar> colorChars = new List<ColorChar>();
            bool creatingCustomPalette = true;

            while (creatingCustomPalette)
            {
                int CursorTopPosition = Console.CursorTop;

                // Schleife für die Zeichenauswahl
                bool selectingCharacter = true;
                while (selectingCharacter)
                {
                    // Zeige das aktuell ausgewählte Zeichen an
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(selectedCharacter);
                    Console.ResetColor();
                    Console.SetCursorPosition(0, CursorTopPosition);
                    Console.WriteLine(" (Foreground color: {0}, Background color: {1}, Character: '{2}')", selectedForegroundColor, selectedBackgroundColor, selectedCharacter);

                    // Pfeiltasten für die Zeichenauswahl
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            // Ausgewähltes Zeichen ändern
                            int characterIndex = Array.IndexOf(availableCharacters, selectedCharacter);
                            if (characterIndex > 0)
                            {
                                selectedCharacter = availableCharacters[characterIndex - 1];
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            // Ausgewähltes Zeichen ändern
                            int characterIndex2 = Array.IndexOf(availableCharacters, selectedCharacter);
                            if (characterIndex2 < availableCharacters.Length - 1)
                            {
                                selectedCharacter = availableCharacters[characterIndex2 + 1];
                            }
                            break;

                        case ConsoleKey.Enter:
                            // Zeichenauswahl beenden und Palette erstellen
                            selectingCharacter = false;
                            break;
                    }
                }

                // Schleife für die Farbauswahl
                bool selectingColors = true;

                while (selectingColors)
                {
                    // Zeige die aktuelle Farbauswahl an
                    Console.ForegroundColor = selectedForegroundColor;
                    Console.BackgroundColor = selectedBackgroundColor;
                    Console.Write(selectedCharacter);
                    Console.ResetColor();
                    Console.SetCursorPosition(0, CursorTopPosition);
                    Console.WriteLine(" (Foreground color: {0}, Background color: {1}, Character: '{2}')", selectedForegroundColor, selectedBackgroundColor, selectedCharacter);

                    // Pfeiltasten für die Farbauswahl
                    ConsoleKeyInfo key2 = Console.ReadKey(true);
                    switch (key2.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            // Ausgewählte Farbe ändern
                            int foregroundIndex = Array.IndexOf(availableColors, selectedForegroundColor);
                            if (foregroundIndex > 0)
                            {
                                selectedForegroundColor = availableColors[foregroundIndex - 1];
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            // Ausgewählte Farbe ändern
                            int foregroundIndex2 = Array.IndexOf(availableColors, selectedForegroundColor);
                            if (foregroundIndex2 < availableColors.Length - 1)
                            {
                                selectedForegroundColor = availableColors[foregroundIndex2 + 1];
                            }
                            break;

                        case ConsoleKey.UpArrow:
                            // Ausgewählte Hintergrundfarbe ändern
                            int backgroundIndex = Array.IndexOf(availableColors, selectedBackgroundColor);
                            if (backgroundIndex > 0)
                            {
                                selectedBackgroundColor = availableColors[backgroundIndex - 1];
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            // Ausgewählte Hintergrundfarbe ändern
                            int backgroundIndex2 = Array.IndexOf(availableColors, selectedBackgroundColor);
                            if (backgroundIndex2 < availableColors.Length - 1)
                            {
                                selectedBackgroundColor = availableColors[backgroundIndex2 + 1];
                            }
                            break;

                        case ConsoleKey.Enter:
                            // Farbauswahl beenden und zur Zeichenauswahl übergehen
                            selectingColors = false;
                            break;
                    }
                }

                // Neue Farbe hinzufügen
                colorChars.Add(new ColorChar(selectedForegroundColor, selectedBackgroundColor, selectedCharacter));

                // Noch eine Farbe hinzufügen?
                Console.WriteLine();
                Console.Write("Do you want to add another color? (Y/N)");
                ConsoleKeyInfo key3 = Console.ReadKey(true);
                if (key3.Key == ConsoleKey.Y || key3.Key == ConsoleKey.Enter)
                {
                    creatingCustomPalette = true;
                }
                else
                {
                    creatingCustomPalette = false;
                }
            }

            Console.CursorVisible = true;
            return new ColorPalette(colorChars);
        }
    }
}
