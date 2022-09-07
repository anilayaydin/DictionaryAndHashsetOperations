using System;
using System.Collections.Generic;

namespace Algorithms {
    class Employee {

        string name;
        int id;
        string department;

        public Employee(string name, int id, string department) {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args) {
            Employee employee = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> employeesById = new Dictionary<int, Employee>();
            employeesById.Add(employee.id, employee);
            employeesById.Add(employee2.id, employee2);
            employeesById.Add(employee3.id, employee3);

            Employee e;
            if(employeesById.TryGetValue(9415, out e)) {
                System.Console.WriteLine(e.name + " : " + e.department);
            }

            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("BF268");
            productCodes.Add("0A43P");
            productCodes.Add("J2H762");

            Console.WriteLine(productCodes.Contains("48DB9"));             
            Console.WriteLine(productCodes.Contains("J2H762"));

        }
    }
}