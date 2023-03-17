namespace Fractal
{
    class Program
    { 
        static void Main(string[] args)
        {
            FractalController fc = new FractalController(180, 60, FractalTyps.MandelbrotSet);
            fc.Run();
        }
    }
}
