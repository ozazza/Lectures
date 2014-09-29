using System;
class Point
{

    // Constructor
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    // Fields
    private int x;
    private int y;

    // Property
    public int X
    {
        get
        {
            return this.x;
        }
        set
        {
            // validation: !!! 
            
            // Make validation in property !!!
            // And let the constructor call that property !!!
            if ((x < 0) || (x > 100))
            {
                throw new ArgumentOutOfRangeException (
                    "Invalid value. Valid values in the range [0..100]");                       
            }
            this.x = value;
        }
    }

    // Property
    public int Y
    {
        get
        {
            return this.y;
        }
        set
        {
            this.y = value;
        }
    }

}

class ClassesExample
{
    static void Main()
    {
        // DateTime d = new DateTime(-2000, 3, 12); // invalid

        Point p1 = new Point(120, -5);
        Console.WriteLine(p1.X);

        Point p2 = new Point(0, 0);


    }
}