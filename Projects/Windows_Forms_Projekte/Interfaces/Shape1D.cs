namespace Polymorphismus
{
    abstract class Shape1D : Shape
    {
        public Shape1D(string c, string n) : base(c, n) { }

        public abstract void getLength();
    }
}
