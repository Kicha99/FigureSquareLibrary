using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquareLibrary
{
    public class Triangle : Figure
    {
        private double _a, _b, _c;

        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Неверные данные");
                _a = value;
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Неверные данные");
                _b = value;
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Неверные данные");
                _c = value;
            }
        }
        public Triangle() : base()
        {
            
        }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Неверные данные");

            _a = a;
            _b = b;
            _c = c;
        }
        public bool IsRectangular()
        {
            // Проверка на прямоугольность
            if (_a > _b && _a > _c)
                return _a * _a == _b * _b + _c * _c;
            if (_b > _a && _b > _c)
                return _b * _b == _a * _a + _c * _c;

            return _c * _c == _a * _a + _b * _b;
        }
        private double SemiPerimeter()
        {
            // Полупериметр
            return (_a + _b + _c) / 2;
        }
        public override double Square()
        {
            double p = SemiPerimeter();

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
