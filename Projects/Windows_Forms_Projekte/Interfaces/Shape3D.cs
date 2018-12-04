namespace Polymorphismus
{
    abstract class Shape3D : Shape
    {
        public Shape3D(string c, string n) : base(c, n) { }

        public double Area { get; set; }
        public double Volume { get; set; }

        public abstract double getArea();
        public abstract double getVolume();
    }
}
