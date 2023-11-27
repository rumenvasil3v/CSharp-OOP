namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Cat("Gosho", 13, "Seamska", "Happy");
            Console.WriteLine(animal.ToString());
        }
    }
}