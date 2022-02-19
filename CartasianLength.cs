using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasianLength;

    public class CartasianLength
    {
        public static void CarLen()
    {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            if (x1 < 0 || y1<0 || x2 <0 || y2<0)

            {
                Console.WriteLine("Please enter positive number");
            }

            else if (x1 == 0 || y1 == 0 || x2 == 0 || y2 == 0)
            {
                Console.WriteLine("Please enter greater than zero");
            }

            else
            {

            double g = Math.Pow((x2 - x1),2);
            double h = Math.Pow((y2 - y1),2);
            double length = g+h;

            Console.WriteLine(g);
            Console.WriteLine(h);
            



            Console.WriteLine("The Length Of Cart" + length+ "in cm");
            
        }
        

    }
        

    }

