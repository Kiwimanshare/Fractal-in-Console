using Fractals.DrawEngine;

namespace Fractal
{
    public class BurningShip : BaseFractal
    {
        public BurningShip(int width, int height, ColorChar[] colorChars) : base(width, height, colorChars) { }

        public override ColorChar[,] Iterate()
        {
            ColorChar[,] buffer = new ColorChar[Width, Height];

            Parallel.For(0, Height, y =>
            {
                for (int x = 0; x < Width; x++)
                {
                    double real = x * (realMax - realMin) / Width + realMin;
                    double imaginary = y * (imaginaryMax - imaginaryMin) / Height + imaginaryMin;

                    int iterations = BurningShipIterations(real, imaginary);

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

        private int BurningShipIterations(double real, double imaginary)
        {
            double zReal = 0.0;
            double zImaginary = 0.0;
            double zRealSquared = 0.0;
            double zImaginarySquared = 0.0;

            int iteration = 0;
            while (zRealSquared + zImaginarySquared < threshold && iteration < maxIterations)
            {
                double newZReal = zRealSquared - zImaginarySquared + real;
                double newZImaginary = Math.Abs(2 * zReal * zImaginary) + imaginary;

                zReal = newZReal;
                zImaginary = newZImaginary;

                zRealSquared = zReal * zReal;
                zImaginarySquared = zImaginary * zImaginary;

                iteration++;
            }

            return iteration == maxIterations ? -1 : iteration;
        }
    }
}