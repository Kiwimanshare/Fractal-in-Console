using Fractal;

namespace Fractals.DrawEngine
{
    public class ParallelDrawEngine : IDrawEngine
    {
        public BaseFractal Fractal { get; set; }

        public ParallelDrawEngine(BaseFractal fractal)
        {
            Fractal = fractal;
        }

        public void Draw()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = Fractal.Iterate();

            object lockObj = new object();

            Parallel.For(0, Fractal.Height, y =>
            {
                for (int x = 0; x < Fractal.Width; x++)
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
    }
}
