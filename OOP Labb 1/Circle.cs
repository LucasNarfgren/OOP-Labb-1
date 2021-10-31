using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_1
{
    public class Circle
    {
        public float Radie;
        public float Pi = 3.141f;

        public Circle (float radie)
        {
            this.Radie = radie;
        }

        public float GetArea(float Radie)
        {
            float CalcArea = Radie * Radie * Pi;
            //int Calc = Convert.ToInt32(CalcArea);
            //return Calc;
            return CalcArea;
        }
        public float GetCircumference(float Radie)
        {
            float CalcCircumference = Radie * 2 * Pi;

            return CalcCircumference;
        }
    }
}
