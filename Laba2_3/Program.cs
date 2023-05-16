using System.Drawing;

namespace Laba2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> a = new Point<double>(0, 0);
            Point<double> b = new Point<double>(0, 0);
            Point<double> c = new Point<double>(0, 0);
            Rectangle<double> r = new Rectangle<double>(a, b, c);
            while(true)
            {
                Console.WriteLine("Значення типу double");
                Console.Write("Ax:"); string AxStr = Console.ReadLine(); double Ax = double.Parse(AxStr);
                Console.Write("Ay:"); string AyStr = Console.ReadLine(); double Ay = double.Parse(AyStr);
                Console.Write("Bx:"); string BxStr = Console.ReadLine(); double Bx = double.Parse(BxStr);
                Console.Write("By:"); string ByStr = Console.ReadLine(); double By = double.Parse(ByStr);
                Console.Write("Cx:"); string CxStr = Console.ReadLine(); double Cx = double.Parse(CxStr);
                Console.Write("Cy:"); string CyStr = Console.ReadLine(); double Cy = double.Parse(CyStr);
                a = new Point<double>(Ax, Ay);
                b = new Point<double>(Bx, By);
                c = new Point<double>(Cx, Cy);
                r = new Rectangle<double>(a,b,c);
                if (r.check())
                {
                    Console.WriteLine("Трикутник прямокутний");
                    break;
                }
                else { Console.WriteLine("Не є прямокутним трикутником"); }
            }
            Console.WriteLine("area: площа прямокутника");
            Console.WriteLine("perimeter: периметр прямокутника");
            Console.WriteLine("stop: закінчення");

            while (true)
            {
                string input1 = Console.ReadLine();
                if (input1 == "area") { Console.WriteLine(r.calculateArea()); }
                if (input1 == "perimeter") { Console.WriteLine(r.calculatePerimeter()); }
                if (input1 == "stop") { break; }

            }
            Point<int> a1 = new Point<int>(0, 0);
            Point<int> b1 = new Point<int>(0, 0);
            Point<int> c1 = new Point<int>(0, 0);
            Rectangle<int> r1 = new Rectangle<int>(a1, b1, c1);
            while (true)
            {
                Console.WriteLine("Значення типу int");
                Console.Write("Ax:"); string AxStr1 = Console.ReadLine(); int Axint = int.Parse(AxStr1);
                Console.Write("Ay:"); string AyStr1 = Console.ReadLine(); int Ayint = int.Parse(AyStr1);
                Console.Write("Bx:"); string BxStr1 = Console.ReadLine(); int Bxint = int.Parse(BxStr1);
                Console.Write("By:"); string ByStr1 = Console.ReadLine(); int Byint = int.Parse(ByStr1);
                Console.Write("Cx:"); string CxStr1 = Console.ReadLine(); int Cxint = int.Parse(CxStr1);
                Console.Write("Cy:"); string CyStr1 = Console.ReadLine(); int Cyint = int.Parse(CyStr1);
                a1 = new Point<int>(Axint, Ayint);
                b1 = new Point<int>(Bxint, Byint);
                c1 = new Point<int>(Cxint, Cyint);
                r1 = new Rectangle<int>(a1, b1, c1);
                Console.WriteLine(Math.Pow(r1.AB, 2) + Math.Pow(r1.BC, 2));
                Console.WriteLine(Math.Pow(r1.AC, 2));
                if (r.check())
                {
                    Console.WriteLine("Трикутник прямокутний");
                    break;
                }
                else { Console.WriteLine("Не є прямокутним трикутником"); }
            }
            Console.WriteLine("area: площа прямокутника");
            Console.WriteLine("perimeter: периметр прямокутника");
            Console.WriteLine("stop: закінчення");

            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2 == "area") { Console.WriteLine(r1.calculateArea()); }
                if (input2 == "perimeter") { Console.WriteLine(r1.calculatePerimeter()); }
                if (input2 == "stop") { break; }

            }


        }
    }
}