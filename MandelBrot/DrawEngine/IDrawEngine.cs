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
        public BaseFractal Fractal { get; set; }
        public void Draw();
    }
}
