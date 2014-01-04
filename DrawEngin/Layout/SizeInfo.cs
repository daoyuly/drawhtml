using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawEngin.Layout
{
    public enum Position
    {
        Static,
        Fixed
    }

    class SizeInfo
    {
        public Position position = Position.Fixed;
        public int X = 0;
        public int Y = 0;
        public int Width = 0;
        public int Heigth = 0;

    }
}
