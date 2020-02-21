using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        public static string Analyze(int tSide1, int tSide2, int tSide3)
        {
            // checking whether the triangle is valid or not
            if ((tSide1 + tSide2 <= tSide3) || (tSide2 + tSide3 <= tSide1) || (tSide1 + tSide3 <= tSide2))
            {
                return "Not valid triangle";
            }
            else
            {
                // checking the type of triangle
                if (tSide1 == tSide2 && tSide2 == tSide3)
                {
                    return "Equilateral Triangle";
                }
                else if (tSide1 == tSide2 || tSide2 == tSide3 || tSide1 == tSide3)
                {
                    return "Isosceles Triangle";
                }
                else
                {
                    return "Scalene Triangle";
                }
            }
        }
    }
}
