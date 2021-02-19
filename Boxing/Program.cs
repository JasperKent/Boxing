using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void CompareBoxes()
        {
            Box<int> myBox = 4;
            object sysBox = 4;

            Console.WriteLine("Homemade ToString: " + myBox);
            Console.WriteLine("System ToString  : " + sysBox);

            Console.WriteLine();
            Console.WriteLine("Homemade GetHashCode: " + myBox.GetHashCode());
            Console.WriteLine("System GetHashCode  : " + sysBox.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("Homemade Equals: " + myBox.Equals(4));
            Console.WriteLine("System Equals  : " + sysBox.Equals(4));

            Console.WriteLine();
            Console.WriteLine("Casting: " + ((int)myBox + (int)sysBox));

            Console.WriteLine();
            Console.WriteLine("Homemade GetType(): " + myBox.GetType());
            Console.WriteLine("System GetType()  : " + sysBox.GetType());
        }

        static void SomeFunc(object o)
        {
            Console.WriteLine(o);

            if (o is Point)
            {
                IPoint p1 = (IPoint)o;

                p1.X = 27;

                Console.WriteLine(p1);
                Console.WriteLine("In the box:");
                Console.WriteLine(o);
            }
        }

        static void Main()
        {
            //CompareBoxes();

            //Point p = new Point { X = 4, Y = 4 };

            //SomeFunc(p);

            //Console.WriteLine(p);

            //IPoint ip = p;

            //ip.X = 44;

            //Console.WriteLine(p);
            //Console.WriteLine(ip);

            ArrayList ars = new ArrayList();

            ars.Add("Fred");
            ars.Add("Wilma");
            ars.Add("Barney");
            ars.Add("Betty");

            List<string> ls = new List<string>();

            ls.Add("Fred");
            ls.Add("Wilma");
            ls.Add("Barney");
            ls.Add("Betty");

            ArrayList ari = new ArrayList();

            ari.Add(1);
            ari.Add(2);
            ari.Add(3);
            ari.Add(4);

            List<int> li = new List<int>();

            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
        }
    }
}
