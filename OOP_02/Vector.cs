using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    class Vector
    {
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector Parse(string s)
        {
            int v = s.IndexOf(',');
            int x = int.Parse(s.Substring(0, v));
            int y = int.Parse(s.Substring(v + 1));

            return new Vector(x, y);
        }
        public string print()
        {
            return "[Vector: x= " + x + " y= " + y+"]";
        }
    }
}
