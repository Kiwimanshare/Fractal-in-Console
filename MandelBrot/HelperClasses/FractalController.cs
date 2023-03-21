using Fractals.DrawEngine;

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
        private T DrawEngine;

        public FractalController(int width, int height, FractalTyps fractal, List<ColorPalette> colorPalettes)
        {
            Width = width;
            Height = height;

            ColorPalettes = colorPalettes;
            ChangePalette();

            Fractal = CreateFractal(fractal);

            DrawEngine = new();
            DrawEngine.Width = Width;
            DrawEngine.Height = Height;
            DrawEngine.IterateFunc = Fractal.Iterate;
            DrawEngine.Draw();
        }

        public IFractal CreateFractal(FractalTyps fractal)
        {
            switch (fractal)
            {
                case FractalTyps.MandelbrotSet:
                    return new MandelbrotSet(Width, Height, currentcolorChars);
                case FractalTyps.JuliaSet:
                    return new JuliaSet(Width, Height, currentcolorChars);
                case FractalTyps.BurningShip:
                    return new BurningShip(Width, Height, currentcolorChars);
                default:
                    return new MandelbrotSet(Width, Height, currentcolorChars);
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

            ConsoleKey key = ConsoleKey.A;

            while (key != ConsoleKey.Escape)
            {
                int stepSize = Console.CapsLock ? 10 : 1;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        cursorPosX = Math.Max(cursorPosX - stepSize, 0);
                        break;
                    case ConsoleKey.DownArrow:
                        cursorPosX = Math.Min(cursorPosX + stepSize, Height);
                        break;
                    case ConsoleKey.LeftArrow:
                        cursorPosY = Math.Max(cursorPosY - stepSize, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        cursorPosY = Math.Min(cursorPosY + stepSize, Width);
                        break;
                    case ConsoleKey.D1:
                        Fractal = CreateFractal(FractalTyps.MandelbrotSet);
                        DrawEngine.Draw();
                        break;
                    case ConsoleKey.D2:
                        Fractal = CreateFractal(FractalTyps.JuliaSet);
                        DrawEngine.Draw();
                        break;
                    case ConsoleKey.D3:
                        Fractal = CreateFractal(FractalTyps.BurningShip);
                        DrawEngine.Draw();
                        break;
                    case ConsoleKey.X:
                        Fractal.Zoom(cursorPosX, cursorPosY, 2.0);
                        DrawEngine.Draw();
                        break;
                    case ConsoleKey.Y:
                        Fractal.Zoom(cursorPosX, cursorPosY, 0.5);
                        DrawEngine.Draw();
                        break;
                    case ConsoleKey.Spacebar:
                        ChangePalette();
                        Fractal.ChangeColor(currentcolorChars);
                        DrawEngine.Draw();
                        break;
                    case ConsoleKey.Enter:
                        Fractal.Zoom(cursorPosX, cursorPosY, 1.0);
                        CursorToCenter(ref cursorPosX, ref cursorPosY);
                        DrawEngine.Draw();
                        break;
                }

                Console.SetCursorPosition(cursorPosY, cursorPosX);
                key = Console.ReadKey(true).Key;
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
