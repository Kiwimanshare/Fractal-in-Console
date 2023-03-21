using Fractal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.DrawEngine
{
    public class BaseDrawEngine : IDrawEngine
    {
        public Func<ColorChar[,]> IterateFunc { get; set; } = EmptyScreen;
        public int Height { get; set; }
        public int Width { get; set; }

        public BaseDrawEngine(int width = 50, int height = 50)
        {
            Height = height;
            Width = width;
        }

        public virtual void Draw()
        {
            Console.Clear();
        }

        public static ColorChar[,] EmptyScreen()
        {
            return new ColorChar[0, 0];
        }
    }
}
