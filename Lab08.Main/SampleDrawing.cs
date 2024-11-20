using Lab08;
using System;
public class SampleDrawing
{
    public void PrintProvidedDrawing()
    {
        List<IGraphic2D> shapes = new List<IGraphic2D>
        {
            new Circle(10, 10, 5) { BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' ' },
            new Circle(8, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
            new Circle(12, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
            new Circle(8, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
            new Circle(12, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
            new Rectangle(8, 13, 4, 0.5m) { ForegroundColor = ConsoleColor.DarkGray, DisplayChar = 'v' },
            new Rectangle(8, 16, 4, 10) { ForegroundColor = ConsoleColor.DarkGreen, DisplayChar = '#' }
        };

        Console.Clear();
        AbstractGraphic2D.Display(shapes);
    }

    public void PrintCatDrawing()
    {
        List<IGraphic2D> shapes = new List<IGraphic2D>
        {
            // Left ear
            new Rectangle(3, 1, 2, 3) { ForegroundColor = ConsoleColor.Gray, DisplayChar = '█' },
            // Right ear
            new Rectangle(10, 1, 2, 3) { ForegroundColor = ConsoleColor.Gray, DisplayChar = '█' },
            // Head
            new Rectangle(2, 4, 12, 6) { ForegroundColor = ConsoleColor.Gray, DisplayChar = '█' },
            // Left eye
            new Rectangle(5, 5, 1, 1) { ForegroundColor = ConsoleColor.Green, DisplayChar = '█' },
            // Right eye
            new Rectangle(10, 5, 1, 1) { ForegroundColor = ConsoleColor.Green, DisplayChar = '█' },
            // Nose
            new Rectangle(7, 7, 2, 1) { ForegroundColor = ConsoleColor.Magenta, DisplayChar = '█' },
        };

        // Clear the console and display the shapes
        Console.Clear();
        AbstractGraphic2D.Display(shapes);
    }
}
