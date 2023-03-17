namespace Mandelbrot_ASCII
{
    class ColorChar
    {
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public char Character { get; set; }

        public ColorChar(ConsoleColor foregroundColor, ConsoleColor backgroundColor, char character)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            Character = character;
        }
    }

    public class MandelbrotSet
    {
        public int Width;
        public int Height;

        private double realMin = -2.0;
        private double realMax = 1.0;
        private double imaginaryMin = -1.0;
        private double imaginaryMax = 1.0;

        private ColorChar[] colorChars;

        public MandelbrotSet(int width, int height)
        {
            Width = width;
            Height = height;

            Console.WindowWidth = Width + 1;
            Console.WindowHeight = Height + 1;

            colorChars = new ColorChar[] {
                new ColorChar(ConsoleColor.DarkBlue,   ConsoleColor.Black, '.'),
                new ColorChar(ConsoleColor.Blue,       ConsoleColor.Black, ':'),
                new ColorChar(ConsoleColor.Cyan,       ConsoleColor.Black, '+'),
                new ColorChar(ConsoleColor.Green,      ConsoleColor.Black, '*'),
                new ColorChar(ConsoleColor.Yellow,     ConsoleColor.Black, 'X'),
                new ColorChar(ConsoleColor.Red,        ConsoleColor.Black, '%'),
                new ColorChar(ConsoleColor.DarkRed,    ConsoleColor.Black, '@'),
                new ColorChar(ConsoleColor.DarkMagenta,ConsoleColor.Black, '#')
            };
        }

        public void Controller()
        {
            int cursorPosX = 0;
            int cursorPosY = 0;
            double zoomFactor = 1.0;

            Draw();

            do
            {
                while (!Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.UpArrow:
                            cursorPosX = Math.Max(cursorPosX - 1, 0);
                            break;
                        case ConsoleKey.DownArrow:
                            cursorPosX = Math.Min(cursorPosX + 1, Height);
                            break;
                        case ConsoleKey.LeftArrow:
                            cursorPosY = Math.Max(cursorPosY - 1, 0);
                            break;
                        case ConsoleKey.RightArrow:
                            cursorPosY = Math.Min(cursorPosY + 1, Width);
                            break;
                        case ConsoleKey.Enter:
                            zoomFactor /= 0.9;
                            Zoom(cursorPosX, cursorPosY, zoomFactor);
                            Draw();
                            break;
                        case ConsoleKey.Spacebar:
                            zoomFactor *= 0.9;
                            Zoom(cursorPosX, cursorPosY, zoomFactor);
                            Draw();
                            break;
                        default:
                            break;
                    }

                    Console.SetCursorPosition(cursorPosY, cursorPosX);

                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public void Zoom(int cursorPosX, int cursorPosY, double zoomFactor)
        {
            double newWidth = (realMax - realMin) / zoomFactor;
            double newHeight = (imaginaryMax - imaginaryMin) / zoomFactor;

            double cursorReal = cursorPosY * (realMax - realMin) / Width + realMin;
            double cursorImaginary = cursorPosX * (imaginaryMax - imaginaryMin) / Height + imaginaryMin;

            realMin = cursorReal - newWidth / 2.0;
            realMax = cursorReal + newWidth / 2.0;

            imaginaryMin = cursorImaginary - newHeight / 2.0;
            imaginaryMax = cursorImaginary + newHeight / 2.0;
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = new ColorChar[Width, Height];

            Parallel.For(0, Height, y =>
            {
                for (int x = 0; x < Width; x++)
                {
                    double real = x * (realMax - realMin) / Width + realMin;
                    double imaginary = y * (imaginaryMax - imaginaryMin) / Height + imaginaryMin;

                    int iterations = MandelbrotIterations(real, imaginary);

                    if (iterations == -1)
                    {
                        buffer[x, y] = new ColorChar(ConsoleColor.Black, ConsoleColor.Black, ' ');
                    }
                    else
                    {
                        int colorCharIndex = (iterations % colorChars.Length);
                        buffer[x, y] = colorChars[colorCharIndex];
                    }
                }
            });

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    ColorChar colorChar = buffer[x, y];
                    Console.ForegroundColor = colorChar.ForegroundColor;
                    Console.BackgroundColor = colorChar.BackgroundColor;
                    Console.Write(colorChar.Character);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        private int MandelbrotIterations(double real, double imaginary, double threshold = 4.0)
        {
            double realPart = 0;
            double imaginaryPart = 0;
            int maxIterations = 1000;

            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                double realSquared = realPart * realPart;
                double imaginarySquared = imaginaryPart * imaginaryPart;

                if (realSquared + imaginarySquared > threshold)
                {
                    return iteration;
                }

                double newRealPart = realSquared - imaginarySquared + real;
                double newImaginaryPart = 2 * realPart * imaginaryPart + imaginary;

                realPart = newRealPart;
                imaginaryPart = newImaginaryPart;
            }

            return -1;
        }
    }
}
