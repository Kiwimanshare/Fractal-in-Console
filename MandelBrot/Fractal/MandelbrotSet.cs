namespace Fractal
{
    public class MandelbrotSet : BaseFractal
    {
        public MandelbrotSet(int width, int height, ColorChar[] colorChars) : base(width, height, colorChars) { }

        public override ColorChar[,] Iterate()
        {
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
                        int colorCharIndex = (iterations % ColorChars.Length);
                        buffer[x, y] = ColorChars[colorCharIndex];
                    }
                }
            });

            return buffer;
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
