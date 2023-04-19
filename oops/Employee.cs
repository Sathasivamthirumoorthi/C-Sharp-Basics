// Implement encapsulation in a program by creating a class called "Employee" with private properties like "salary" and public methods like "getSalary" and "setSalary".

using System;

namespace MyProblem{
    class Employee{
        private string name;
        private int employeeId; 
        private int salary;

        public string Name{
            get{return name;}
            set{name = value;}
        }

        public int EmployeeId{
            get{return employeeId;}
            set{employeeId = value;}
        }
        public int Salary{
            get{return salary;}
            set{salary = value;}
        }
    }
       
}