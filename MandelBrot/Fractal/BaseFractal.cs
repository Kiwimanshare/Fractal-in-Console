using Fractals.DrawEngine;

namespace Fractal
{
    public class BaseFractal : IFractal
    {
        protected ColorChar[] ColorChars;
        protected double imaginaryMax = 1.0;
        protected double imaginaryMin = -2.0;

        protected int maxIterations = 1000;
        protected double realMax = 1.0;
        protected double realMin = -2.0;
        protected double threshold = 4.0;

        public int Height { get; protected set; }
        public int Width { get; protected set; }

        public IDrawEngine drawEngine { get; protected set; }

        public BaseFractal(int width, int height, ColorChar[] colorChars)
        {
            Width = width;
            Height = height;
            ColorChars = colorChars;
            drawEngine = new TopBottomDrawEngine(this);
        }

        public BaseFractal(int height, int width, ColorChar[] colorChars, IDrawEngine drawEngine)
        {
            Width = width;
            Height = height;
            ColorChars = colorChars;
            this.drawEngine = drawEngine;
        }

        public void Draw() => drawEngine.Draw();

        public void ChangeColor(ColorChar[] colorChars)
        {
            ColorChars = colorChars;
        }

        public virtual void Zoom(int cursorPosX, int cursorPosY, double zoomFactor)
        {
            double newWidth = (realMax - realMin) / zoomFactor;
            double newHeight = (imaginaryMax - imaginaryMin) / zoomFactor;

            double cursorReal = cursorPosY * (realMax - realMin) / Width + realMin;
            double cursorImaginary = cursorPosX * (imaginaryMax - imaginaryMin) / Height + imaginaryMin;

            realMin = cursorReal - newWidth / 2.0;
            realMax = cursorReal + newWidth / 2.0;

            imaginaryMin = cursorImaginary - newHeight / 2.0;
            imaginaryMax = cursorImaginary + newHeight / 2.0;
        }

        public virtual ColorChar[,] Iterate()
        {
            return new ColorChar[Width, Height];
        }
    }
}