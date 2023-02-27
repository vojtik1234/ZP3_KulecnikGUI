using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KulecnikGUI
{
    public class Kulicka
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int vektorX { get; set; }
        public int vektorY { get; set; }

        public Kulicka(int x, int y, int vektorX, int vektorY)
        {
            X = x;
            Y = y;
            this.vektorX = vektorX;
            this.vektorY = vektorY;
        }
    }
}
