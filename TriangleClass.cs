using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAssignemnt2SQA
{
    class TriangleClass
    {

        public static string Analyze(ref List<int> sides)
        {
            int maxSide = sides.Max();
            sides.Remove(maxSide);

            int minSide = sides.Min();
            sides.Remove(minSide);

            int mediumSide = sides[0];
            sides.Remove(mediumSide);

            string output = "The sides do not form a triangle!";

            if ((minSide + mediumSide) - maxSide > 0)
            {
                if (minSide == maxSide)
                {
                    output = "This is an equilateral triangle!";
                }
                else if (minSide == mediumSide || minSide == maxSide || mediumSide == maxSide)
                {
                    output = "This is an isosceles triangle!";
                }
                else
                {
                    output = "This is an scalene triangle!";
                }
            }

            return output;
        }
    }
}
