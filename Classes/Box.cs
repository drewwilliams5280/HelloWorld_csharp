using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Box
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public int Volume
        {
            get
            {
                return this.Length * this.Height * this.Width;
            }
        }

        public int FrontSurface
        {
            get
            {
                return Width * Height;
            }
        }

        public Box(int length, int height, int width)
        {
            Length = length;
            Width = width;
            Height = height;
        }



        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                Length, Height, Width, Volume);
        }

    }
}
