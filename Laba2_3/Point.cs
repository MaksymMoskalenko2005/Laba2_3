using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_3
{
    class Point<T> where T : struct, IComparable<T>
    {
        public T X { get; set; }
        public T Y { get; set; }


        public Point() : this(default(T), default(T))
        { }
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        public T getX()
        {
            return this.X;
        }
        public T getY()
        {
            return this.Y;
        }
    }
    internal class Rectangle<T> where T : struct, IComparable<T>
    {
        private Point<T> center, A, B, C, D;
        public double AB, BC, CD, AD, AC;

        public Rectangle(Point<T> a, Point<T> b, Point<T> c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.AB = calculateLength(A, B);
            this.BC = calculateLength(B, C);
            this.D = new Point<T>((dynamic)C.X, (dynamic)A.Y);
            this.CD = calculateLength(C, D);
            this.AD = calculateLength(A, D);
            this.AC = calculateLength(A, C);
            this.center = new Point<T>(((dynamic)A.X + (dynamic)c.X) / 2, ((dynamic)A.Y + (dynamic)C.Y) / 2);
        }


        public double calculatePerimeter()
        {
            return AB + BC + CD + AD;
        }

        public double calculateArea()
        {
            return AB * BC;
        }

        private double calculateLength(Point<T> point1, Point<T> point2)
        {
            return Math.Sqrt(PowDouble(point1.X, point2.X) + PowDouble(point1.Y, point2.Y));
        }

        private double PowDouble(T point1, T point2)
        {
            return Math.Pow(Convert.ToDouble(point1) - Convert.ToDouble(point2), 2);
        }

        public void changePoints(Point<T> a, Point<T> b, Point<T> c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.AB = calculateLength(A, B);
            this.BC = calculateLength(B, C);
            this.D = new Point<T>((dynamic)C.X, (dynamic)A.Y);
            this.CD = calculateLength(C, D);
            this.AD = calculateLength(A, D);
            this.center = new Point<T>(((dynamic)A.X + (dynamic)c.X) / 2, ((dynamic)A.Y + (dynamic)C.Y) / 2);
        }
        public double ABplusBCPow2() { return Math.Pow(AB,2)  + Math.Pow(BC, 2); }
        public double ABplusACPow2() { return Math.Pow(AB, 2) + Math.Pow(AC, 2); }
        public double ACplusBCPow2() { return Math.Pow(AC, 2) + Math.Pow(BC, 2); }
        public bool check()
        {
            if ((ABplusBCPow2()==Math.Round(Math.Pow(AC,2)))||(ABplusACPow2() == Math.Round(Math.Pow(BC, 2)))||(ACplusBCPow2() == Math.Round(Math.Pow(AB, 2))))
            {
                return true;
            }
            else return false;
        }

    }
}
