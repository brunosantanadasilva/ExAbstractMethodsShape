
using ExAbstractMethodsShape.Entities.Enums;

namespace ExAbstractMethodsShape.Entities
{
    internal abstract class Shape
    {
        Color Color { get; set; }
         
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
