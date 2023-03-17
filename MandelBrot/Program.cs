using System;

namespace Mandelbrot_ASCII
{
    class Program
    { 
        static void Main(string[] args)
        {
            MandelbrotSet ms = new MandelbrotSet(180, 64);
            ms.Controller();
        }
    }
}
