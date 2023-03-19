using Fractal;
using System;
using System.Runtime.InteropServices;

namespace Fractals.DrawEngine
{
    public class FastDrawEngine : BaseDrawEngine
    {
        private const uint GENERIC_WRITE = 0x40000000;
        private const uint STD_OUTPUT_HANDLE = 0xFFFFFFF5;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(uint nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteConsoleOutput(IntPtr hConsoleOutput, CHAR_INFO[] lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

        [StructLayout(LayoutKind.Sequential)]
        public struct COORD
        {
            public short X;
            public short Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SMALL_RECT
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct CHAR_INFO
        {
            [FieldOffset(0)]
            public char UnicodeChar;
            [FieldOffset(0)]
            public byte AsciiChar;
            [FieldOffset(2)]
            public short Attributes;
        }
        public static CHAR_INFO ToCharInfo(ColorChar cc)
        {
            CHAR_INFO ci = new CHAR_INFO();
            ci.UnicodeChar = cc.Character;
            ci.Attributes = (short)(((int)cc.BackgroundColor << 4) | (int)cc.ForegroundColor);
            return ci;
        }

        public override void Draw(int height, int width)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            ColorChar[,] buffer = IterateFunc.Invoke();

            IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);

            CHAR_INFO[] charInfoBuffer = new CHAR_INFO[width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    charInfoBuffer[y * width + x] = ToCharInfo(buffer[x, y]);
                }
            }

            COORD bufferSize = new COORD { X = (short)width, Y = (short)height };
            COORD bufferCoord = new COORD { X = 0, Y = 0 };
            SMALL_RECT writeRegion = new SMALL_RECT { Left = 0, Top = 0, Right = (short)(width - 1), Bottom = (short)(height - 1) };

            WriteConsoleOutput(hConsole, charInfoBuffer, bufferSize, bufferCoord, ref writeRegion);

            Console.CursorVisible = true;
        }
    }
}
