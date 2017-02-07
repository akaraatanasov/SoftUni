﻿namespace RectPos
{
    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom => Top - Height;

        public int Right => Left + Width;

        public int Area => Height * Width;
    }
}