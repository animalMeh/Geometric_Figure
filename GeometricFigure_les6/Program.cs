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
        }
    }
}
