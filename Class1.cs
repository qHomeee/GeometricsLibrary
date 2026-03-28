namespace Geometrics
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля.", nameof(radius));
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetDiameter()
        {
            return 2 * Radius;
        }
    }

    public class Square
    {
        public double SideLength { get; private set; }

        public Square(double sideLength)
        {
            if (sideLength <= 0)
                throw new ArgumentException("Длина стороны должна быть больше нуля.", nameof(sideLength));
            SideLength = sideLength;
        }

        public double GetArea()
        {
            return Math.Pow(SideLength, 2);
        }

        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public double GetDiagonal()
        {
            return SideLength * Math.Sqrt(2);
        }
    }

    public class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Длины сторон должны быть больше нуля.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Существуют ли такие стороны треугольника? Проверьте длины.");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public (double AngleA, double AngleB, double AngleC) GetAngles()
        {
            double angleA = Math.Acos((Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) / (2 * SideB * SideC));
            double angleB = Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) / (2 * SideA * SideC));
            double angleC = Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) / (2 * SideA * SideB));
            return (angleA * (180 / Math.PI), angleB * (180 / Math.PI), angleC * (180 / Math.PI));
        }
    }

    public class Rectangle
    {
        public double Length { get; private set; }
        public double Width { get; private set; }

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
                throw new ArgumentException("Длины сторон должны быть больше нуля.");
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2));
        }
    }

    public class Trapezoid
    {
        public double BaseA { get; private set; }
        public double BaseB { get; private set; }
        public double SideC { get; private set; }
        public double SideD { get; private set; }
        public double Height { get; private set; }

        public Trapezoid(double baseA, double baseB, double sideC, double sideD, double height)
        {
            if (baseA <= 0 || baseB <= 0 || sideC <= 0 || sideD <= 0 || height <= 0)
            {
                throw new ArgumentException("Все параметры должны быть больше нуля.");
            }
            BaseA = baseA;
            BaseB = baseB;
            SideC = sideC;
            SideD = sideD;
            Height = height;
        }

        public double GetArea()
        {
            return ((BaseA + BaseB) / 2) * Height;
        }

        public double GetPerimeter()
        {
            return BaseA + BaseB + SideC + SideD;
        }
    }
}