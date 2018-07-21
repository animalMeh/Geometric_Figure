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
            return "(" + X + ";" + Y +")";
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
        public static double GetAngleBy3Sides(double f, double s , double th)
        {
            return Math.Acos(  (Math.Pow(f, 2) + Math.Pow(s, 2) - Math.Pow(th, 2)) / (2 * f * s)  );
        }

        public override string ToString()
        {
            return InDegrees + "_d";
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
        public void ChangeCenterCoordintes(double x , double y)
        {
            CenterPoint.SetNewCoordinates(x, y);
        }
        public virtual string GetCenterCoordinates()
        { return CenterPoint.ToString(); }
        protected virtual double Perimetr()
        { return 0.0; }
        protected virtual double Area ()
        { return 0.0; }


        public string GetPerimetr()
        {
            return "Perimeter is " + Perimetr();
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

            CenterPoint = new Point((_f.X + _s.X + _th.X) / 3, (_f.Y + _s.Y + _th.Y) / 3);
           
            FirstAngle = new Angle(Angle.GetAngleBy3Sides(DistanceBetweenSecondtAndThirdPoint(),
               DistanceBetweenThirdAndFirstPoint(), DistanceBetweenFirstAndSecondPoint() ));
            SecondAngle = new Angle(Angle.GetAngleBy3Sides(DistanceBetweenThirdAndFirstPoint(),
                DistanceBetweenFirstAndSecondPoint(),DistanceBetweenSecondtAndThirdPoint() ));
            ThirdAngle = new Angle( Angle.GetAngleBy3Sides( DistanceBetweenFirstAndSecondPoint(),
                DistanceBetweenSecondtAndThirdPoint(), DistanceBetweenThirdAndFirstPoint()));

        }
        private double DistanceBetweenFirstAndSecondPoint()
        {
            return FirstPoint.GiveDistanceBetween(SecondPoint);
        }
        private double DistanceBetweenSecondtAndThirdPoint()
        {
            return SecondPoint.GiveDistanceBetween(ThirdPoint);
        }
        private double DistanceBetweenThirdAndFirstPoint()
        {
            return ThirdPoint.GiveDistanceBetween(FirstPoint);
        }
        public string GetAngles()
        {
            return "First:" + FirstAngle.ToString() + ";\t\tSecond:"+ SecondAngle.ToString() + ";\t\tThird:"+ ThirdAngle.ToString();
        }
        public override string GetCenterCoordinates()
        {
            return "Center of Triangle " + base.GetCenterCoordinates() ;
        }
        protected override double Perimetr()
        {
            return DistanceBetweenFirstAndSecondPoint() + DistanceBetweenSecondtAndThirdPoint() + DistanceBetweenThirdAndFirstPoint();
        }
    }

    class Circle : GeometricFigure
    {
        private double Radius;

        public Circle(Point Center, double Radius)
            :base(Center)
        {
            this.Radius = Radius;
        }
        public override string GetCenterCoordinates()
        {
            return "Center of Circle " + base.GetCenterCoordinates();
        }
        protected override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        } 
        
    }
}
