using P03.Detail_Printer;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class StartUp
    {
        static void Main()
        {
            DetailsPrinter printer = new(new List<Employee>()
            {
                new Manager("Gosho", new List<string> {"Expenses", "Meetings", "EmployeeTasks"}),
                new Programmer("Ivailo", "Java")
            }) ;

            printer.PrintDetails();
        }
    }
}
