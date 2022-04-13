namespace ConsoleApp1
{
    public class Figure
    {
        protected double perimeter;
        protected double square;

        public virtual double GetPerimeter() { return this.perimeter; }

        public virtual double GetSquare() { return this.square; }

        public static void Main() { }
    }


    public class Triangle : Figure
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            SetPerimeter();
            SetSquare();
        }

        #region SETTERS AND GETTERS
        public double GetA() { return this.a; }
        public void SetA(double a) 
        { 
            this.a = a;
            SetPerimeter();
            SetSquare();
        }

        public double GetB() { return this.b; }
        public void SetB(double b) 
        {
            this.b = b;
            SetPerimeter();
            SetSquare();
        }

        public double GetC() { return this.c; }
        public void SetC(double c) 
        {
            this.c = c;
            SetPerimeter();
            SetSquare();
        }

        public override double GetPerimeter() { return this.perimeter; }

        private void SetPerimeter()
        {
            this.perimeter = this.a + this.b + this.c;
        }

        public override double GetSquare() { return this.square; }

        // Площадь через 3 стороны
        private void SetSquare()
        {
            this.square = Math.Sqrt(this.perimeter / 2 * 
                (this.perimeter / 2 - this.a) * 
                (this.perimeter / 2 - this.b) *
                (this.perimeter / 2 - this.c));
        }
        #endregion

        public bool IsRight()
        {
            // Если теорема Пифагора выполняется, то
            if ((this.c * this.c) == (this.a * this.a) + (this.b * this.b) ||
                (this.b * this.b) == (this.a * this.a) + (this.c * this.c) ||
                (this.a * this.a) == (this.b * this.b) + (this.c * this.c))
            {
                return true; // треугольник прямоугольный
            }
            return false; // треугольник не прямоугольный
        }
    }


    public class Circle : Figure
    {
        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            SetPerimeter();
            SetSquare();
        }

        #region SETTERS AND GETTERS
        public double GetRadius() { return this.radius; }
        public void SetRadius(double radius) 
        {
            this.radius = radius;
            SetPerimeter();
            SetSquare();
        }

        public override double GetPerimeter() { return this.perimeter; }

        private void SetPerimeter()
        {
            this.perimeter = 2 * Math.PI * this.radius;
        }

        public override double GetSquare() { return this.square; }

        private void SetSquare()
        {
            this.square = Math.PI * this.radius * this.radius;
        }
        #endregion
    }


    public class Rectangle : Figure
    {
        protected double width;
        protected double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            SetPerimeter();
            SetSquare();
        }

        #region SETTERS AND GETTERS
        public double GetWidth() { return this.width; }

        public void SetWidth(double width) 
        {
            this.width = width;
            SetPerimeter();
            SetSquare();
        }

        public double GetHeight() { return this.height; }

        public void SetHeight(double height)
        {
            this.height = height;
            SetPerimeter();
            SetSquare();
        }

        public override double GetPerimeter() { return this.perimeter; }

        private void SetPerimeter()
        {
            this.perimeter = (this.width + this.height) * 2;
        }

        public override double GetSquare() { return this.square; }

        private void SetSquare()
        {
            this.square = this.width * this.height;
        }
        #endregion
    }
}
