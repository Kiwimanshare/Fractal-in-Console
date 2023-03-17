﻿namespace Fractal
{
    public class FractalBase : IFractal
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

        public FractalBase(int width, int height, ColorChar[] colorChars)
        {
            Width = width;
            Height = height;
            ColorChars = colorChars;
        }

        public void ChangeColor(ColorChar[] colorChars)
        {
            ColorChars = colorChars;
            Draw();
        }

        public void Zoom(int cursorPosX, int cursorPosY, double zoomFactor)
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

        public virtual void Draw()
        {
            Console.WriteLine("No Function implemented");
        }
    }
}