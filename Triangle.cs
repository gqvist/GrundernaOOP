using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    internal class Triangle
    {
        // Create variables for base and height
        private int _base;
        private int _height;

        // Create constructor for base and height
        public Triangle(int b, int h)
        {
            _base = b;
            _height = h;
        }

        // Calculate the area of a right triangle
        public double GetArea()
        {
            return (_base * _height) * 0.5;
        }

        // Calculate the perimiter of right triangle (using pythagoras theorem) 
        public double GetPerimeter()
        {
            return (Math.Sqrt((Math.Pow(_base,2) + Math.Pow(_height,2))) + _height + _base);
        }
    }
}
