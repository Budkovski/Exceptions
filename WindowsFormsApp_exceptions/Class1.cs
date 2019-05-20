using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_exceptions
{
    class Class1
    {
        private double bok;
        public double Bok
        {
            get { return bok; }
            set
            {
                if (value<=0)
                {
                    throw new MyException("Wartość boka musi być liczbą dodatnią",value);
                }
                else
                {
                    bok = value;
                }
            }
        }
        public double pole_kw()
        {
            
            return bok * 4;

        }
        private double x, y;
        public double X
        {
            get { return x; }
            set
            {
                if (value<=0)
                {
                    throw new MyException("Wartość boka musi być liczbą dodatnią", value);
                }
                else
                {
                    x = value;
                }
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                if (value <= 0)
                {
                    throw new MyException("Wartość boka musi być liczbą dodatnią", value);
                }
                else
                {
                    y = value;
                }
            }
        }


        public double obwod_pr()
        {
            return 2*x+2*y;
        }

        private int znam = 0;
        public int Znam
        {
            get { return znam; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Sproba dzelenia na 0");
                }
                else
                {
                    znam = value;
                }
            }
        }
        public int podziel(int x)
        {
            return x / znam;
        }

        public double pomnoz(double x,double y)
        {
            return x * y;
        }
    }
}
