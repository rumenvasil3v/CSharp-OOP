namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.StealFieldIndo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}