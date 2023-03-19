namespace Fractal
{
    public class BaseFractal : IFractal
    {
        protected ColorChar[] ColorChars;
        protected double imaginaryMax = 1.0;
        protected double imaginaryMin = -2.0;

        protected int maxIterations = 1000;
        protected double realMax = 1.0;
        protected double realMin = -2.0;
        protected double threshold = 4.0;

        public int Height { get; protected set; }
        public int Width { get; protected set; }

        public BaseFractal(int width, int height, ColorChar[] colorChars)
        {
            Width = width;
            Height = height;
            ColorChars = colorChars;
        }

        public void ChangeColor(ColorChar[] colorChars)
        {
            ColorChars = colorChars;
        }

        public virtual void Zoom(int cursorPosX, int cursorPosY, double zoomFactor)
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
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = Iterate();

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
            Console.CursorVisible = true;
        }

        public void Draw2()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = Iterate();

            object lockObj = new object(); 

            Parallel.For(0, Height, y =>
            {
                for (int x = 0; x < Width; x++)
                {
                    ColorChar colorChar = buffer[x, y];
                    lock (lockObj) 
                    {
                        Console.ForegroundColor = colorChar.ForegroundColor;
                        Console.BackgroundColor = colorChar.BackgroundColor;
                        Console.SetCursorPosition(x, y); 
                        Console.Write(colorChar.Character);
                    }
                }
            });

            Console.ResetColor();
            Console.CursorVisible = true;
        }

        public virtual ColorChar[,] Iterate()
        {
            return new ColorChar[Width, Height];
        }
    }
}