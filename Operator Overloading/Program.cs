using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            box a = new box(); //first box
            a.h = 4; //height
            a.l = 2;//length
            a.w = 9;//width

            box b = new box();//second box
            b.w = 5;
            b.l = 3;
            b.h = 6;
            box z = new box(); // another object to receive value from operator
            z = a + b;
            Console.WriteLine("NEW VOLUME = " + z.volume());
        }
        class box
        {
            public int h, w, l;
            public int volume()
            {
                return (h * l * w);
            }
            public static box operator+ (box a,box b) //operator + oveloading
            {
                box c = new box(); // to sign data in 
                c.l = a.l + b.l;
                c.w = a.w + b.w;  // we add the width from both objects and sign it to the Var. in the new object
                c.h = a.h + b.h;
                return c;
            }
        }
    }
}
