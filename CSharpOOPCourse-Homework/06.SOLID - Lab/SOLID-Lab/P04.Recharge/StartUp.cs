using System;

namespace P04.Recharge
{
    class StartUp
    {
        static void Main()
        {
            Worker employee = new Employee("324");

            employee.Work(4);
            employee.Work(10);

            Console.WriteLine($"Employee ID: {employee.Id} worked {employee.WorkingHours}");

            Worker robot = new Robot("324", 20, 20);

            robot.Work(4);
            robot.Work(10);
            robot.Work(10);

            Console.WriteLine($"Robot ID: {robot.Id} worked {robot.WorkingHours}");
        }
    }
}