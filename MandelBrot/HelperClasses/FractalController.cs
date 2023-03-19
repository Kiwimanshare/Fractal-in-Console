﻿using Fractals.DrawEngine;

namespace Fractal
{
    public class FractalController<T>
        where T : IDrawEngine, new()
    {
        public int Width;
        public int Height;

        private List<ColorPalette> ColorPalettes;
        private int currentPaletteIndex = 0;
        private ColorChar[] currentcolorChars;

        private IFractal Fractal;

        public FractalController(int width, int height, FractalTyps fractal, List<ColorPalette> colorPalettes)
        {
            Width = width;
            Height = height;

            ColorPalettes = colorPalettes;
            ChangePalette();

            Fractal = CreateFractal(fractal);

            Fractal.Draw();
        }

        public IFractal CreateFractal(FractalTyps fractal)
        {
            switch (fractal)
            {
                case FractalTyps.MandelbrotSet:
                    return new MandelbrotSet<T>(Width, Height, currentcolorChars);
                case FractalTyps.JuliaSet:
                    return new JuliaSet<T>(Width, Height, currentcolorChars);
                case FractalTyps.BurningShip:
                    return new BurningShip<T>(Width, Height, currentcolorChars);
                default:
                    return new MandelbrotSet<T>(Width, Height, currentcolorChars);
            }
        }

        public void ChangePalette()
        {
            currentPaletteIndex = (currentPaletteIndex + 1) % ColorPalettes.Count;
            currentcolorChars = ColorPalettes[currentPaletteIndex].ColorChars.ToArray();
        }

        public void AddColorPalette(ColorPalette palette)
        {
            ColorPalettes.Add(palette);
        }

        public void Run()
        {
            int cursorPosX = 0;
            int cursorPosY = 0;

            CursorToCenter(ref cursorPosX, ref cursorPosY);

            ConsoleKey key = ConsoleKey.RightArrow;

            while (key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true).Key;

                int stepSize = Console.CapsLock ? 10 : 1;
                bool draw = false;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        cursorPosX = Math.Max(cursorPosX - stepSize, 0);
                        draw = false;
                        break;
                    case ConsoleKey.DownArrow:
                        cursorPosX = Math.Min(cursorPosX + stepSize, Height);
                        draw = false;
                        break;
                    case ConsoleKey.LeftArrow:
                        cursorPosY = Math.Max(cursorPosY - stepSize, 0);
                        draw = false;
                        break;
                    case ConsoleKey.RightArrow:
                        cursorPosY = Math.Min(cursorPosY + stepSize, Width);
                        draw = false;
                        break;
                    case ConsoleKey.D1:
                        Fractal = CreateFractal(FractalTyps.MandelbrotSet);
                        draw = true;
                        break;
                    case ConsoleKey.D2:
                        Fractal = CreateFractal(FractalTyps.JuliaSet);
                        draw = true;
                        break;
                    case ConsoleKey.D3:
                        Fractal = CreateFractal(FractalTyps.BurningShip);
                        draw = true;
                        break;
                    case ConsoleKey.X:
                        Fractal.Zoom(cursorPosX, cursorPosY, 2.0);
                        draw = true;
                        break;
                    case ConsoleKey.Y:
                        Fractal.Zoom(cursorPosX, cursorPosY, 0.5);
                        draw = true;
                        break;
                    case ConsoleKey.Spacebar:
                        ChangePalette();
                        Fractal.ChangeColor(currentcolorChars);
                        draw = true;
                        break;
                    case ConsoleKey.Enter:
                        Fractal.Zoom(cursorPosX, cursorPosY, 1.0);
                        CursorToCenter(ref cursorPosX, ref cursorPosY);
                        draw = true;
                        break;
                }

                if (draw)
                    Fractal.Draw();

                Console.SetCursorPosition(cursorPosY, cursorPosX);
            }
        }

        private void CursorToCenter(ref int x, ref int y)
        {
            y = Width / 2;
            x = Height / 2;
            Console.SetCursorPosition(y, x);
        }
    }
}
