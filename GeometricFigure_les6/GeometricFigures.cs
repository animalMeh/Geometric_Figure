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
       public double X { get; set; } 
       public double Y { get; set; }
    }

    class GeometricFigure
    {
        protected Point CenterPoint;
        public GeometricFigure()
        {
            CenterPoint.X = 0.0;
            CenterPoint.Y = 0.0;
        }
        public GeometricFigure(Point _c)
        {
            CenterPoint = _c;
        }
        public bool Equals(GeometricFigure g)
        {
            return this.CenterPoint.X == g.CenterPoint.X && this.CenterPoint.Y == g.CenterPoint.Y;
        }
        public void ChangeCenterCoordintes(double _newX , double _newY)
        {
            CenterPoint.X = _newX;
            CenterPoint.Y = _newY;
        }
    }
}
