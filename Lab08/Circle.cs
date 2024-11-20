namespace Lab08;

public class Circle : AbstractGraphic2D
{
    public override decimal LowerBoundX => centerX - radius;

    public override decimal UpperBoundX => centerX + radius;

    public override decimal LowerBoundY => centerY - radius;

    public override decimal UpperBoundY => centerY + radius;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return (x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius * radius;
    }

    public bool ContainsPoint(double x, double y)
    {
        // Calculate the difference in the x-coordinates
        double dx = x - centerX;
        
        // Calculate the difference in the y-coordinates
        double dy = y - centerY;
        
        // Calculate the square of the distance from the point to the center
        double distanceSquared = dx * dx + dy * dy;
        
        // Check if the distance is less than or equal to the square of the radius
        return distanceSquared <= (double)radius * (double)radius;
    }

    private int centerX;
    public int CenterX
    {
        get { return centerX; }
    }
    private int centerY;
    public int CenterY
    {
        get { return centerY; }
    }
    private decimal radius;
    public decimal Radius
    {
        get { return radius; }
    }
    //constructor that takes x, y, and radius
    public Circle(int x, int y, decimal radius)
    {
        this.centerX = x;
        this.centerY = y;
        this.radius = radius;
        DisplayChar = '■';
        ForegroundColor = ConsoleColor.Red;
        BackgroundColor = ConsoleColor.White;
        //Console.WriteLine($"LowerBoundX: {LowerBoundX}");
        //Console.WriteLine($"UpperBoundX: {UpperBoundX}");
        //Console.WriteLine($"LowerBoundY: {LowerBoundY}");
        //Console.WriteLine($"UpperBoundY: {UpperBoundY}");
    }
}