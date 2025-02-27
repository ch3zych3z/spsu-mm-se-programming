﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class SobelX : MatrixFilter
    {
        internal SobelX()
        {
            matrix = new double[]
            {
                -1, 0, 1,
                -2, 0, 2,
                -1, 0, 1
            };
        }

        public override void PixelConverse(ref RGB[,] pixels, int height, int width)
        {
            new GrayScale().PixelConverse(ref pixels, height, width);
            base.PixelConverse(ref pixels, height, width);
        }
    }
}
