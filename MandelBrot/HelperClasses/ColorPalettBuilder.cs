namespace Fractal
{
    public static class ColorPalettBuilder
    {
        public static List<ColorPalette> BuildColorPalette()
        {
            return new List<ColorPalette>
            {
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
                    // ...
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
                })
                };
        }
    }
}
