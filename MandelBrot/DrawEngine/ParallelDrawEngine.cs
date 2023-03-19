using Fractal;

namespace Fractals.DrawEngine
{
    public class ParallelDrawEngine : BaseDrawEngine
    {
        public override void Draw(int height, int width)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = IterateFunc.Invoke();

            object lockObj = new object();

            Parallel.For(0, height, y =>
            {
                for (int x = 0; x < width; x++)
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
