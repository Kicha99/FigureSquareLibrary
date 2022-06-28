using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquareLibrary
{
    public class Circle : Figure
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Неверный радиус");
                _r = value;
            }
        }
        public Circle() : base()
        {

        }
        public Circle(double r)
        {
            _r = r;
        }
        public override double Square()
        {
            return Math.PI * Math.Pow(2, R);
        }
    }
}
