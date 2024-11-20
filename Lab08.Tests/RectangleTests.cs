using NUnit.Framework;

namespace Lab08.Tests;

public class RectangleTests
{
    Rectangle rectangle = null!;
    AbstractGraphic2D shape = null!;

    [SetUp]
    public void Setup()
    {
        rectangle = new Rectangle(3, 4, 5, 6);
        shape = rectangle;
    }

    [Test]
    public void EnsurePropertiesAreCorrect()
    {
        Assert.That(rectangle.Left, Is.EqualTo(3));
        Assert.That(rectangle.Top, Is.EqualTo(4));
        Assert.That(rectangle.Width, Is.EqualTo(5));
        Assert.That(rectangle.Height, Is.EqualTo(6));
    }

    [Test]
    public void CheckLowerBounds()
    {
        // lower bound is the smallest x that needs to be checked when drawing the shape
        Assert.That(shape.LowerBoundX, Is.EqualTo(3));
        Assert.That(shape.LowerBoundY, Is.EqualTo(4));
    }

    [Test]
    public void CheckUpperBounds()
    {
        // upper bound is the largest x that needs to be checked when drawing the shape
        Assert.That(shape.UpperBoundX, Is.EqualTo(3 + 5));
        Assert.That(shape.UpperBoundY, Is.EqualTo(4 + 6));
    }

    [Test]
    public void MiddleOfShapeIsIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(5.5m, 7));
    }

    [Test]
    public void CornersIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(3, 4));
        Assert.IsTrue(shape.ContainsPoint(8, 4));
        Assert.IsTrue(shape.ContainsPoint(3, 10));
        Assert.IsTrue(shape.ContainsPoint(8, 10));
    }

    [Test]
    public void OutsideOfCornersNotIncludedInShape()
    {
        Assert.IsFalse(shape.ContainsPoint(3 - 0.1m, 4));
        Assert.IsFalse(shape.ContainsPoint(8, 4 - 0.1m));
        Assert.IsFalse(shape.ContainsPoint(3, 10 + 0.1m));
        Assert.IsFalse(shape.ContainsPoint(8 + 0.1m, 10));
    }
}