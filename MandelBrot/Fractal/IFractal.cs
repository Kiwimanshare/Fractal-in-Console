namespace Fractal
{
    public enum FractalTyps
    {
        MandelbrotSet = 0,
        JuliaSet = 1,
        BurningShip = 2,
        Lyapunov = 3
    }

    public interface IFractal
    {
        int Width { get; }
        int Height { get; }
        void Draw();
        void Zoom(int cursorPosX, int cursorPosY, double zoomFactor);
        void ChangeColor(ColorChar[] colorChars);
    }
}
