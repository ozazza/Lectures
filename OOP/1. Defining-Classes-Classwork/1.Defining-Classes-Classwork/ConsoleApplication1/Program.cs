using System;

class Point
{
    // CONSTRUCTOR:

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    // PROPERTIES:

    /// <summary>
    ///             can be read free but not write free
    /// </summary>
    public int X { get; private set; }

    /// <summary>
    ///             can be read free and write free
    /// </summary>
    public int Y { get; set; }

}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        p1.X = 20;
        p1.Y = -5;
        Console.WriteLine(p1.X);
        Point p2 = new Point();
        p2.X = 0;
        p2.Y = 0;

    }
}