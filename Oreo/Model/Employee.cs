﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oreo.Model
{
    class Employee
    {
        private string _document;
        private string _name;
        private string _adress;

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

        public string Address
        {
            get { return _adress; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _adress = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Client Name.");
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------

        public static Employee getAllInfo()
        {
            Employee Employee = new Employee();
            Console.Write("\n\tClient Document: ");
            Employee.Document = Console.ReadLine();
            Console.Write("\tClient Name: ");
            Employee.Name = Console.ReadLine();
            Console.Write("\tClient Address: ");
            Employee.Address = Console.ReadLine();
            return Employee;
        }

        public static Employee getDocument()
        {
            Employee Employee = new Employee();
            Console.Write("\n\tWrite Client Document: ");
            Employee.Document = Console.ReadLine();
            return Employee;
        }
    }
}
