using System;
using System.Collections.Generic;
using System.Text;

namespace Oreo.Model
{
    class Employee
    {
        private string _document;
        private string _name;
        private decimal _salary;

        public string Document
        {
            get { return _document; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _document = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Client Document.");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Client Name.");
                }
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0 && value < 100000000)
                {
                    _salary = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Client Salary");
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------

        public static Employee getAllInfo()
        {
            Employee Employee = new Employee();
            Console.Write("\n\tEscribe su documento: ");
            Employee.Document = Console.ReadLine();
            Console.Write("\tEscribe su nombre: ");
            Employee.Name = Console.ReadLine();
            Console.Write("\tEscribe su sueldo: ");
            Employee.Salary = decimal.Parse(Console.ReadLine());
            return Employee;
        }

        public static Employee getDocument()
        {
            Employee Employee = new Employee();
            Console.Write("\n\tEscribe su documento: ");
            Employee.Document = Console.ReadLine();
            return Employee;
        }
    }
}
