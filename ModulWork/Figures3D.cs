using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public class Figures3D
    {
        public virtual double CalcSurfaceArea()
        {
            return 0; 
        }

        public virtual double CalcVolume()
        {
            return 0; 
        }
    }

    public class Parallelepiped : Figures3D
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Parallelepiped(double length, double width, double height)
        {
            a = length;
            b = width;
            c = height;
        }

        public override double CalcSurfaceArea()
        {
            return 2 * (a * b + a * c + b * c);
        }

        public override double CalcVolume()
        {
            return a * b * c;
        }
    }

    public class Conus : Figures3D
    {
        public double r { get; set; }
        public double h { get; set; }

        public Conus(double radius, double height)
        {
            r = radius;
            h = height;
        }

        public double l()
        {
            return Math.Sqrt(r * r + h * h);
        }

        public override double CalcSurfaceArea()
        {
            return Math.PI * r * l() + Math.PI * r * r;
        }

        public override double CalcVolume()
        {
            return (CalcSurfaceArea() * h) / 3;
        }
    }

    public class Sphere : Figures3D
    {
        public double r { get; set; }

        public Sphere(double radius)
        {
            r = radius;
        }

        public override double CalcSurfaceArea()
        {
            return 4 * Math.PI * r * r;
        }

        public override double CalcVolume()
        {
            return (4 * Math.PI * Math.Pow(r, 3)) / 3;
        }
    }
}
