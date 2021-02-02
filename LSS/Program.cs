using System;

namespace LSS_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer worker = new Engineer("Jonathan Dean", "$20,000", "05/12/2405");

            worker.getName();
            worker.getSalary();
            worker.hiredDate();
        }
    }

    class Employee
    {
        string name { get; set; }
        string salary { get; set; }
        string hireDate { get; set; }

        public Employee()
        {
            name = "";
            salary = "";
            hireDate = "";
        }

        public Employee(string name, string salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        public virtual string getName()
        {
            Console.WriteLine($"Employee Name: {name}");
            return name;
        }

        public virtual string getSalary()
        {
            Console.WriteLine($"Salary: {salary}");
            return salary;
        }

        public virtual string hiredDate()
        {
            Console.WriteLine($"Hire Date {hireDate}");
            return hireDate;
        }
    }

    class Engineer : Employee
    {
        string schoolAttended { get; set; }

        public Engineer(string name, string salary, string hireDate) 
            : base(name, salary, hireDate)
        {
            schoolAttended = "";
        }

        public Engineer(string schoolAttended)
        {
            this.schoolAttended = schoolAttended;
        }
    }
}
