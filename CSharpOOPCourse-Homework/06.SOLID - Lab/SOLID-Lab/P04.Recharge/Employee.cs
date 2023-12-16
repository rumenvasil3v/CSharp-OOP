namespace P04.Recharge
{
    using System;
    using P04.Recharge.Contracts;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}