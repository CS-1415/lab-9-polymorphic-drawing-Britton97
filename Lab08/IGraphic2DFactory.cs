namespace Lab08
{
    public interface IGraphic2DFactory
    {
        public string Name { get; }
        public IGraphic2D Create();
    }

    public class CircleFactory : IGraphic2DFactory
    {
        public string Name => "Circle";

        public IGraphic2D Create()
        {
            int x, y;
            decimal radius;

            // Ask user for x-coordinate
            Console.WriteLine("Enter the x-coordinate of the center of the circle: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }

            // Ask user for y-coordinate
            Console.WriteLine("Enter the y-coordinate of the center of the circle: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }

            // Ask user for radius
            Console.WriteLine("Enter the radius of the circle: ");
            while (!decimal.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid input. Please enter a decimal.");
            }

            return new Circle(x, y, radius);
        }
    }

    //rectangle factory
    public class RectangleFactory : IGraphic2DFactory
    {
        public string Name => "Rectangle";

        public IGraphic2D Create()
        {
            decimal left, top, width, height;

            // Ask user for left coordinate
            Console.WriteLine("Enter the left coordinate of the rectangle: ");
            while (!decimal.TryParse(Console.ReadLine(), out left))
            {
                Console.WriteLine("Invalid input. Please enter a decimal.");
            }

            // Ask user for top coordinate
            Console.WriteLine("Enter the top coordinate of the rectangle: ");
            while (!decimal.TryParse(Console.ReadLine(), out top))
            {
                Console.WriteLine("Invalid input. Please enter a decimal.");
            }

            // Ask user for width
            Console.WriteLine("Enter the width of the rectangle: ");
            while (!decimal.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid input. Please enter a decimal.");
            }

            // Ask user for height
            Console.WriteLine("Enter the height of the rectangle: ");
            while (!decimal.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input. Please enter a decimal.");
            }

            return new Rectangle(left, top, width, height);
        }
    }
}