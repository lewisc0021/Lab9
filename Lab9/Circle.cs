using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        private double radius;

        public double RADIUS
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }




        }

        public Circle(double rad)
        {
            RADIUS = rad;        
        }


        public double GetCircumference()
        {
            return 2 * Math.PI * RADIUS;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(RADIUS, 2);           
        }

        private string formatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }

        public string getFormattedCircumference()
        {
            return formatNumber(GetCircumference()); //not sure on this
        }

        public string getFormattedArea()
        {
            return formatNumber(GetArea()); //not sure on this
        }




        }} //END----------------------------------------------------------------END//

