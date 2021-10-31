using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_1
{
    public class Triangle
    {
        public float _height;
        public float _width;

        public Triangle(float height, float width)
        {
            this._height = height;
            this._width = width;
        }

        public float GetArea()
        {
            float calcArea = _height * _width / 2;
            return calcArea;
        }
    }
}
