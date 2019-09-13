using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrotfraktal
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex Coord = new Complex(-0.6, 1.2);
            Complex Temp;
            int iterations;

            while(Coord.Imag >= -1.2)
            {
                while(Coord.Real <= 1.77)
                {
                    iterations = 0;
                    Temp = new Complex(Coord);

                    while (Temp.Argument < 4 && ++iterations < 50)
                        Temp = Temp * Temp + Coord;

                    switch (iterations % 5)
                    {
                        case 0:
                            Console.Write(' ');
                            break;
                        case 1:
                            Console.Write('.');
                            break;
                        case 2:
                            Console.Write('o');
                            break;
                        case 3:
                            Console.Write('O');
                            break;
                        case 4:
                            Console.Write('@');
                            break;
                    }

                    //Erik ist der Beste



                    Coord.Real += 0.03;
                    Console.WriteLine();
                    Coord.Imag += 0.05;
                    Coord.Real = -0.6;
                }
            }
            Console.ReadKey();
        }
    }
}
