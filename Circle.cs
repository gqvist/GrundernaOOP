using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    internal class Circle
    {
        // Create the variable _radius
        private int _radius;

        // Create constructor for radius
        public Circle(int r)
        {
            _radius = r;
        }

        // Calculate the area of a circle
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        // Calculate the circumference of a circle
        public double GetCircumference()
        {
          return 2 * Math.PI * _radius;  
        }

        // Calculate the volume of a sphere
        public double GetVolume()
        {
          return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }

    }
}
