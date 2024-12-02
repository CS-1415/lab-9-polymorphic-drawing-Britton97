using System;
using System.Collections.Generic;
using Lab08;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Drawing Program!");
        Console.WriteLine("This program will iteratively allow you to either draw or modify an existing drawing.");

        List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>
        {
            // Add instances of available factories here
            new CircleFactory(),
            new RectangleFactory()
            // Add other shape factories here
        };

        List<IGraphic2D> builtShapes = new List<IGraphic2D>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Display drawing");
            Console.WriteLine("2. Add graphic");
            Console.WriteLine("3. Remove graphic");
            Console.WriteLine("0. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        AbstractGraphic2D.Display(builtShapes);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Choose a shape to create:");
                        for (int i = 0; i < availableShapeTypes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {availableShapeTypes[i].Name}");
                        }
                        if (int.TryParse(Console.ReadLine(), out int shapeChoice) && shapeChoice > 0 && shapeChoice <= availableShapeTypes.Count)
                        {
                            IGraphic2DFactory selectedFactory = availableShapeTypes[shapeChoice - 1];
                            IGraphic2D shape = selectedFactory.Create();
                            builtShapes.Add(shape);
                            Console.WriteLine($"{selectedFactory.Name} created and added to the list.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"There are {builtShapes.Count} graphic objects in the current drawing.");
                        Console.WriteLine("Enter the index of the graphic to remove (1-based index):");
                        if (int.TryParse(Console.ReadLine(), out int removeIndex) && removeIndex > 0 && removeIndex <= builtShapes.Count)
                        {
                            builtShapes.RemoveAt(removeIndex - 1);
                            Console.WriteLine("Graphic removed from the list.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index. Please try again.");
                        }
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}