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
        public Func<ColorChar[,]> IterateFunc { get; set; }
        public void Draw(int height, int width);
    }
}
