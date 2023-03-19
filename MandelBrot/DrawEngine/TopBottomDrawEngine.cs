using Fractal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.DrawEngine
{
    public class TopBottomDrawEngine : IDrawEngine
    {
        public BaseFractal Fractal { get; set; }

        public TopBottomDrawEngine(BaseFractal fractal)
        {
            Fractal = fractal;
        }

        public void Draw()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = Fractal.Iterate();

            for (int y = 0; y < Fractal.Height; y++)
            {
                for (int x = 0; x < Fractal.Width; x++)
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
    }
}
