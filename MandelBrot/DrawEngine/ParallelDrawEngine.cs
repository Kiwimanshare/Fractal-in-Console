using Fractal;

namespace Fractals.DrawEngine
{
    public class ParallelDrawEngine : BaseDrawEngine
    {
        public override void Draw()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = IterateFunc.Invoke();

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
    }
}
