using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure_les6
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure simple1 = new GeometricFigure( new Point(1.1, 1.7));
            GeometricFigure simple2 = new GeometricFigure(new Point(0.0, 1.1));
            Console.WriteLine(simple1.Equals(simple2));
            simple1.ChangeCenterCoordintes(0.0, 1.1);
            Console.WriteLine(simple1.Equals(simple2));
            Triangle t = new Triangle(new Point(1.0, 0.0), new Point(0.0, 0.0), new Point(0.0, 1.0));
            Console.WriteLine( "First Point: {0} ; Second Point: {1} ; Third Point: {2} ;" , t.FirstPoint , t.SecondPoint , t.ThirdPoint);
            Console.WriteLine("Dist 1: {0} , Dist 2: {1} , Dist 3; {2}", t.DistanceBetweenFirstAndSecondPoint(),
                t.DistanceBetweenSecondtAndThirdPoint(), t.DistanceBetweenThirdAndFirstPoint());
            Console.WriteLine(t.GetAngles());
            Console.WriteLine(t.GetCenterCoordinates());
        }
    }
}
