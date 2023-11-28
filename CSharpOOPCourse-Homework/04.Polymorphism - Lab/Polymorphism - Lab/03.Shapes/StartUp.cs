namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(3);
            Console.WriteLine($"{circle.Draw()}:");
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());

            Console.WriteLine("----------------------------");

            Shape rectangle = new Rectangle(5, 10);
            Console.WriteLine($"{rectangle.Draw()}:");
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
        }
    }
}