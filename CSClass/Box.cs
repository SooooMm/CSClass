using System;

namespace CSClass
{
    internal class Box
    {
        private int width;
        private int height;

        public int foo { get; set; }

        public int Width
        { 
            get { return width; }
            set {
                if (width > 0) width = value;
                else Console.WriteLine("양수여야 합니다.");
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (height > 0) height = value;
                else Console.WriteLine("양수여야 합니다.");
            }
        }

        public Box(int width, int height)
        {
          this.width = width;
          this.height = height;
          
            
        }

        private int area;
        public int Area { 
            get { return this.width*this.height; }
        }
       
    }
}