namespace Lab08;

public class Rectangle : AbstractGraphic2D
{
    public override decimal LowerBoundX => Left;

    public override decimal UpperBoundX => Left + Width;

    public override decimal LowerBoundY => Top;

    public override decimal UpperBoundY => Top + Height;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        // Check if the point is within the horizontal bounds of the rectangle
        bool withinHorizontalBounds = x >= Left && x <= Left + Width;
        
        // Check if the point is within the vertical bounds of the rectangle
        bool withinVerticalBounds = y >= Top && y <= Top + Height;
        
        // The point is inside the rectangle if it is within both the horizontal and vertical bounds
        return withinHorizontalBounds && withinVerticalBounds;
    }

    public bool ContainsPoint(double x, double y)
    {
        // Check if the point is within the horizontal bounds of the rectangle
        bool withinHorizontalBounds = x >= (double)Left && x <= (double)Left + (double)Width;
        
        // Check if the point is within the vertical bounds of the rectangle
        bool withinVerticalBounds = y >= (double)Top && y <= (double)Top + (double)Height;
        
        // The point is inside the rectangle if it is within both the horizontal and vertical bounds
        return withinHorizontalBounds && withinVerticalBounds;
    }

    private decimal leftX;
    private decimal topY;
    private decimal width;
    private decimal height;

    // Property for Left
    public decimal Left
    {
        get { return leftX; }
        set { leftX = value; }
    }

    // Property for Top
    public decimal Top
    {
        get { return topY; }
        set { topY = value; }
    }

    // Property for Width
    public decimal Width
    {
        get { return width; }
        set { width = value; }
    }

    // Property for Height
    public decimal Height
    {
        get { return height; }
        set { height = value; }
    }

    // Constructor that takes x, y, width, and height
    public Rectangle(decimal x, decimal y, decimal width, decimal height)
    {
        this.Left = x;
        this.Top = y;
        this.Width = width;
        this.Height = height;
        DisplayChar = '■';
    }
}