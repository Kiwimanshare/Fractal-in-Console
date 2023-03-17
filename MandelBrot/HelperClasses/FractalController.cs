namespace Fractal
{
    public class FractalController
    {
        public int Width;
        public int Height;

        private List<ColorPalette> colorPalettes;
        private int currentPaletteIndex = 0;
        private ColorChar[] currentcolorChars;

        private IFractal Fractal;

        public FractalController(int width, int height, FractalTyps fractal)
        {
            Width = width;
            Height = height;

            Console.WindowWidth = Width + 1;
            Console.WindowHeight = Height + 1;

            SetCurrentColor();

            Fractal = CreateFractal(fractal);
        }

        public IFractal CreateFractal(FractalTyps fractal)
        {
            switch (fractal)
            {
                case FractalTyps.MandelbrotSet:
                    return new MandelbrotSet(Width, Height, currentcolorChars);
                case FractalTyps.JuliaSet:
                    return new JuliaSet(Width, Height, currentcolorChars);
                default:
                    return new MandelbrotSet(Width, Height, currentcolorChars);
            }
        }

        public void ChangePalette()
        {
            currentPaletteIndex = (currentPaletteIndex + 1) % colorPalettes.Count;
            currentcolorChars = colorPalettes[currentPaletteIndex].ColorChars.ToArray();
        }

        private void ChangeCurrentPaletteIndex(int value)
        {
            if (value > 0)
                currentPaletteIndex = Math.Min(value, colorPalettes.Count);
            else
                currentPaletteIndex = 0;
        }

        private void SetCurrentColor()
        {
            colorPalettes = ColorPalettBuilder.BuildColorPalette();
            currentcolorChars = colorPalettes[currentPaletteIndex].ColorChars.ToArray();
        }

        public void Run()
        {
            int cursorPosX = 0;
            int cursorPosY = 0;
            double zoomFactor = 1.0;

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                while (!Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    bool capsLockPressed = Console.CapsLock;
                    int stepSize = capsLockPressed ? 10 : 1;


                    switch (key.Key)
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
                        case ConsoleKey.X:
                            zoomFactor /= 0.5;
                            ZoomAndDraw(cursorPosX, cursorPosY, zoomFactor);
                            break;
                        case ConsoleKey.Y:
                            zoomFactor *= 0.5;
                            ZoomAndDraw(cursorPosX, cursorPosY, zoomFactor);
                            break;
                        case ConsoleKey.Spacebar:
                            ChangePalette();
                            Fractal.ChangeColor(currentcolorChars);
                            break;
                        default:
                            continue;
                    }
                    Console.SetCursorPosition(cursorPosY, cursorPosX);
                }
            } 
        }

        private void ZoomAndDraw(int X, int Y, double Z)
        {
            Fractal.Zoom(X, Y, Z);
            Fractal.Draw();
        }
    }
}
