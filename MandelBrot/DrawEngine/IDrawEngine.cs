using Fractal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.DrawEngine
{
    public interface IDrawEngine
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Func<ColorChar[,]> IterateFunc { get; set; }
        public void Draw();
    }
}
