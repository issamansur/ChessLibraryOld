﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    public enum Color
    {
        None,
        White,
        Black
    }

    public static class ColorMethods
    {
        public static Color FlipColor(this Color color)
        {
            switch (color)
            {
                case Color.White:
                    return Color.Black;
                case Color.Black:
                    return Color.White;
                default:
                    return Color.None;
            }
        }
    }
}
