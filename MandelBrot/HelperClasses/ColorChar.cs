namespace Fractal
{
    public class ColorChar
    {
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public char Character { get; set; }

        public ColorChar(ConsoleColor foregroundColor, ConsoleColor backgroundColor, char character)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            Character = character;
        }
    }
}
