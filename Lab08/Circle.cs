namespace Lab08;

public class Circle : AbstractGraphic2D
{
    public override decimal LowerBoundX => -1;

    public override decimal UpperBoundX => -1;

    public override decimal LowerBoundY => -1;

    public override decimal UpperBoundY => -1;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}