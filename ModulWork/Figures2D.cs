using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public class Figures2D
    {
        public virtual double CalcPerimeter()
        {
            return 0;
        }

        public virtual double CalcArea()
        {
            return 0;
        }

        public virtual double OpisRadius()
        {
            return 0;
        }

        public virtual double WpisRadius()
        {
            return 0;
        }
    }

    public class Triangle : Figures2D
    {
        public double b { get; set; }
        public double a { get; set; }

        public Triangle(double basisLength, double legsLength)
        {
            b = basisLength;
            a = legsLength;
        }

        public override double CalcPerimeter()
        {
            return b + 2 * a;
        }

        public double h()
        {
            return Math.Sqrt(a * a - (b * b) / 4);
        }

        public override double CalcArea()
        {
            return 0.5 * b * h();
        }

        public override double OpisRadius()
        {
            return (a * a) / (2 * h());
        }

        public override double WpisRadius()
        {
            return (2 * a * b - b * b) / (4 * h());
        }
    }

    public class Square : Figures2D
    {
        public double a { get; set; }

        public Square(double length)
        {
            a = length;
        }

        public override double CalcPerimeter()
        {
            return 4 * a;
        }

        public override double CalcArea()
        {
            return a * a;
        }

        public override double OpisRadius()
        {
            return a / Math.Sqrt(2);
        }

        public override double WpisRadius()
        {
            return a / 2;
        }
    }
}
