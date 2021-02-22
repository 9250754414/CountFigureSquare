using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFigureSquare
{
    public class Triangle : Figure
    {
        
        private double a;
        private double b;
        private double c;
        List<double> count = new List<double>(3);

        /// <summary>
        /// Property, length of the А side. (Must be greater than 0)
        /// </summary>
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A must be > 0");
                }
                else
                {
                    a = value;
                }
            }
        }
        /// <summary>
        /// Property, length of the В side. (Must be greater than 0)
        /// </summary>
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("B must be > 0");
                }
                else
                {
                    b = value;
                }
            }
        }
        /// <summary>
        /// Property, length of the C side. (Must be greater than 0)
        /// </summary>
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("C must be > 0");
                }
                else
                {
                    c = value;
                }
            }
        }
        /// <summary>
        /// A property that determines whether a triangle is rightTriangle
        /// </summary>
        public bool rightTriangle
        {
            
            get
            {

                count.Add(a);
                count.Add(b);
                count.Add(c);
                count.Sort();
                if ((count[0] * count[0]) + (count[1] * count[1]) == count[2] * count[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        /// <summary>
        /// A constructor that creates a triangle object. With sides A, B, C.(Each side must be less than the sum of the other two)
        /// </summary>
        /// <param name="A1">The length of the side A</param>
        /// <param name="B1">The length of the side В</param>
        /// <param name="C1">The length of the side С</param>
        public Triangle(double A1, double B1, double C1)
        {
            if (A1 < B1 + C1 && B1 < A1 + C1 && C1 < A1 + B1)
            {
                A = A1;
                B = B1;
                C = C1;
            }
            else
            {
                throw new Exception("Not possible: each side must be less than the sum of the other two");
                        
            } 
        
        
        }
        /// <summary>
        /// Method for calculating the area of a triangle
        /// </summary>
        /// <returns></returns>
        public override double CountSquare()
        {
            double p = (a + b + c) / 2;
            var result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;

        }
        
    }
}
