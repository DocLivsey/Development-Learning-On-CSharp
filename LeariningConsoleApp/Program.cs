// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

public class Point
{
    protected double x { set; get; }
    protected double y { set; get; }
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public double DistanceTo(Point point)
    { return Math.Sqrt(Math.Pow((point.x - this.x), 2) + Math.Pow((point.y - this.y), 2)); }
}

public class Triangle
{
    protected Point A;
    protected Point B;
    protected Point C;
    public Triangle(Point A, Point B, Point C)
    {
        if (this.CanMakeTriangle())
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        else
        {
            this.A = new Point(0, 0);
            this.B = new Point(0, 0);
            this.C = new Point(0, 0);
        }
    }
    public bool CanMakeTriangle()
    {
        return A.DistanceTo(B) + B.DistanceTo(C) > C.DistanceTo(A) &&
               A.DistanceTo(B) < B.DistanceTo(C) + C.DistanceTo(A) &&
               A.DistanceTo(B) + A.DistanceTo(C) > C.DistanceTo(B);
    }
}

public class Procedure
{
    public static void Main(String[] args)
    {
        Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 1), new Point(2, 4));
    }
}