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
            Console.WriteLine(@"
Hello and Welcome!
Now we have only two figures - Triangle and Circle
Choose operations with them:");
            
            Circle c;
            Triangle t;
            bool ik = false;
            while (true)
            {
                Console.WriteLine(@"
A - Create new Circle
B - Create new Triangle  
Q - quit 
                    ");
                if (ik == true)
                    break;
                char cep = Convert.ToChar(Console.ReadLine());
                switch(cep)
                {
                    case 'A':
                        {
                            Console.WriteLine("construct it! Enter Center of Circle and its Radius: \n X coordinate of center: ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(" Y coordinate of center: ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter length of radius: ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            c = new Circle(new Point(x, y), r);
                            Console.WriteLine(@"
Do you want do smth with this Circle? 
Choose it:
A - center point coordinates, B - perimetr , W - quite");
                                bool i = false;
                            while(true)
                            {
                                if (i == true)
                                    break;
                                char cep1 = Convert.ToChar(Console.ReadLine());
                                switch (cep1)
                                {
                                    case 'A':
                                        Console.WriteLine(c.GetCenterCoordinates());
                                        break;
                                    case 'B':
                                        Console.WriteLine(c.GetPerimetr());
                                        break;
                                    case 'W':
                                        Console.WriteLine("Go Next!");
                                        i = true;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        }
                    case 'B':
                        {
                            Console.WriteLine("construct it! Enter Coordinates of Triangle\n X coordinate : ");
                            double Fx = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Coordinates of Triangle\n Y coordinate : ");
                            double Fy = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Coordinates of Triangle \n X coordinate : ");
                            double Sx = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Coordinates of Triangle\n Y coordinate : ");
                            double Sy = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Coordinates of Triangle\n X coordinate : ");
                            double Thx = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Coordinates of Triangle \n Y coordinate : ");
                            double Thy = Convert.ToDouble(Console.ReadLine());
                            t = new Triangle(new Point(Fx, Fy), new Point(Sx, Sy), new Point(Thx, Thy));

                            Console.WriteLine(@"Do you want do smth with this Triangle? 
                                Choose it: \n  A - center point coordinates, B - perimetr, C -angles , W - quite");
                            bool i = false;
                            while (true)
                            {
                                if (i == true)
                                    break;
                                char cep1 = Convert.ToChar(Console.ReadLine());
                                switch (cep1)
                                {
                                    case 'A':
                                        Console.WriteLine(t.GetCenterCoordinates());
                                        break;
                                    case 'B':
                                        Console.WriteLine(t.GetPerimetr());
                                        break;
                                    case 'C':
                                        Console.WriteLine(t.GetAngles());
                                        break;
                                    case 'W':
                                        Console.WriteLine("Go Next!");
                                        i = true;
                                        break;
                                    default:
                                        continue;
                                }
                            }


                        }
                        break;
                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        ik = true;
                        break;
                    default:
                        break;
                }

            }
        }
        
    }
}
