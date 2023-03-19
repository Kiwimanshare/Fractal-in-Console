namespace Fractal
{
    public class JuliaSet : BaseFractal
    {
        private double cReal = -0.8;
        private double cImaginary = 0.156;
        public JuliaSet(int width, int height, ColorChar[] colorChars) : base(width, height, colorChars) { }

        public override ColorChar[,] Iterate()
        {
            ColorChar[,] buffer = new ColorChar[Width, Height];

            Parallel.For(0, Height, y =>
            {
                for (int x = 0; x < Width; x++)
                {
                    double real = x * (realMax - realMin) / Width + realMin;
                    double imaginary = y * (imaginaryMax - imaginaryMin) / Height + imaginaryMin;

                    int iterations = JuliaIterations(real, imaginary);

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

        private int JuliaIterations(double real, double imaginary, double threshold = 4.0, int maxIterations = 1000)
        {
            double realPart = real;
            double imaginaryPart = imaginary;

            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                double realSquared = realPart * realPart;
                double imaginarySquared = imaginaryPart * imaginaryPart;

                if (realSquared + imaginarySquared > threshold)
                {
                    return iteration;
                }

                double newRealPart = realSquared - imaginarySquared + cReal;
                double newImaginaryPart = 2 * realPart * imaginaryPart + cImaginary;

                realPart = newRealPart;
                imaginaryPart = newImaginaryPart;
            }

            return -1;
        }
    }
}

