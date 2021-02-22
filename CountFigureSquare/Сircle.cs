using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFigureSquare
{
    public class Сircle : Figure
    {
        private double radius;
        /// <summary>
        /// Property, length of the radius. (Must be greater than 0)
        /// </summary>
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be > 0");
                }
                else
                {
                    radius = value;
                }

            }
        }
        double Pi = 3.14159;
        /// <summary>
        /// Method for calculating the area of a circle
        /// </summary>
        /// <returns></returns>
        public override double CountSquare()
        {
            double result = Pi * radius * radius;
            return result;
        }
        /// <summary>
        /// A constructor that creates a circle object.(radius must be > 0)
        /// </summary>
        /// <param name="rad">Radius</param>
        public Сircle(double rad)
        {
            if (rad > 0)
            {
                Radius = rad;
            }
            else
            {
                throw new Exception("Not possible: radius must be > 0");
            }
            
        }
    }
}
