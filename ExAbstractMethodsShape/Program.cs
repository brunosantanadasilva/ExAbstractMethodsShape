using System.Globalization;
using ExAbstractMethodsShape.Entities;
using ExAbstractMethodsShape.Entities.Enums;

namespace ExAbstractMethodsShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();
           
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle ( r / c ) ? ");
                char rc = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                
                while (rc != 'c' && rc != 'r')
                {
                    Console.WriteLine("Rectangle or Circle ( r / c ) ? ");
                }

                if (rc == 'r')
                {
                    Console.Write("Width : ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height : ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle (width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
                Console.WriteLine();
            }
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}