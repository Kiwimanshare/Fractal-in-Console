namespace Fractal
{
    public class MandelbrotSet : IFractal
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        private double realMin = -2.0;
        private double realMax = 1.0;
        private double imaginaryMin = -1.0;
        private double imaginaryMax = 1.0;

        private ColorChar[] ColorChars;

        public MandelbrotSet() { }
        public MandelbrotSet(int width, int height, ColorChar[] colorChars)
        {
            Width = width;
            Height = height;
            ColorChars = colorChars;
            Draw();
        }

        public void ChangeColor(ColorChar[] colorChars)
        {
            ColorChars = colorChars;
            Draw();
        }

        public void Draw()
        {
            ColorChar[,] buffer = new ColorChar[Width, Height];

            Console.SetCursorPosition(0, 0);

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
                        int colorCharIndex = (iterations % ColorChars.Length);
                        buffer[x, y] = ColorChars[colorCharIndex];
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

        private int MandelbrotIterations(double real, double imaginary, double threshold = 4.0, int maxIterations = 1000)
        {
            double realPart = 0;
            double imaginaryPart = 0;

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
