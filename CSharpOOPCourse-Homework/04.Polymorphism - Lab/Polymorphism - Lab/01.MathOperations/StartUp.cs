namespace Operations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            Console.WriteLine(operations.Add(4, 5));
            Console.WriteLine(operations.Add(6d, -7d));
            Console.WriteLine(operations.Add(223m, 1234m));
        }
    }
}