using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private ICollection<Employee> employees;

        public DetailsPrinter(ICollection<Employee> employees)
        {
            this.employees = new List<Employee>(employees);
        }

        public void PrintDetails()
        {
            foreach (Employee employee in this.employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}