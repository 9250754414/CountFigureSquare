using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFigureSquare
{
    public abstract class Figure
    {
        
        
        public string Name { get; set; }
        /// <summary>
        /// Method for calculating the area of a figure
        /// </summary>
        /// <returns></returns>
        public abstract double CountSquare();
       
        
        


    }
}
