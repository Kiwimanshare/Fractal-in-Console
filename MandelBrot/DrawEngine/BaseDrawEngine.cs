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

        public virtual void Draw(int height, int width)
        {
            Console.Clear();
        }

        public static ColorChar[,] EmptyScreen()
        {
            return new ColorChar[0, 0];
        }
    }
}
