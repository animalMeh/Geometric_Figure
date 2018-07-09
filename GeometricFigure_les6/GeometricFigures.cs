using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure_les6
{
    struct Point
    {
        public Point(double x , double y)
        {
            X = x;
            Y = y;
        }
        public void SetNewCoordinates(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double GiveDistanceBetween(Point t)
        {
            return Math.Sqrt( Math.Pow(t.X - this.X , 2) + Math.Pow(t.Y - this.Y , 2));
        }
        public override string ToString()
        {
            return X + " " + Y;
        }
        public double X { get;private set; } 
       public double Y { get;private set; }
    }

    struct Angle
    {
        public Angle( float _deg)
        {
            InDegrees = _deg;
            InRadians = (double)_deg * Math.PI / 180;
        }
        public Angle (double _rad)
        {
            InRadians = _rad;
            InDegrees = (float)(_rad * 180 / Math.PI);
        }

        public void SetNewAngle(float _d)
        {
            InDegrees = _d;
            InRadians = (double)_d * Math.PI / 180;
        }
        public void SetNewAngle(double _r)
        {
            InRadians = _r;
            InDegrees = (float)(_r * 180 / Math.PI);
        }

        public float InDegrees { get; private set; }
        public double InRadians { get;private set; }
    }

    class GeometricFigure
    {
        protected Point CenterPoint;
        public GeometricFigure()
        {
            CenterPoint = new Point(0.0, 0.0);
        }
        public GeometricFigure(Point _c)
        {
            CenterPoint = _c;
        }
        public bool Equals(GeometricFigure g)
        {
            return this.CenterPoint.X == g.CenterPoint.X && this.CenterPoint.Y == g.CenterPoint.Y;
        }
        public void ChangeCenterCoordintes(double x , double y)
        {
            CenterPoint.SetNewCoordinates(x, y);
        }
    }
    class Triangle : GeometricFigure
    {
        public Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }
        public Point ThirdPoint { get; private set; }
        private Angle FirstAngle, SecondAngle, ThirdAngle;

        public Triangle(Point _f , Point _s, Point _th)
        {
            FirstPoint = _f;
            SecondPoint = _s;
            ThirdPoint = _th;
        }
        public double DistanceBetweenFirstAndSecondPoint()
        {
            return FirstPoint.GiveDistanceBetween(SecondPoint);
        }
        public double DistanceBetweenSecondtAndThirdPoint()
        {
            return SecondPoint.GiveDistanceBetween(ThirdPoint);
        }
        public double DistanceBetweenThirdAndFirstPoint()
        {
            return ThirdPoint.GiveDistanceBetween(FirstPoint);
        }
    }
}
