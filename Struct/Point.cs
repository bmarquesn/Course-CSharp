namespace Struct
{
    struct Point
    {
        public double X;
        public double Y;

        public override readonly string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
