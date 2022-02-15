using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee_Management_System
    {
        public static List<Employee> employees = new List<Employee>();
        public static void add_employee(Employee dummy)
        {
            employees.Add(dummy);
        }
        public static Employee get_employee(int id)
        {

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == id)
                {
                    return employees[i];
                }
            }
          
            throw new search_not_found_exception();

        }
        public static void update_employee(Employee dummy, int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == id)
                {
                    employees[i] = dummy;
                    return;
                }
            }

            throw new search_not_found_exception();
            return;
        }
    }
    internal class search_not_found_exception : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Searched index not found";
            }
        }
    }
    internal class Employee
    {
        public int id;
        public string name;
        public string contact;
        public double salary;
        public DateTime date_of_joining;
        public int leaves;
        public string designation;
        public virtual double get_salary()
        {
            return salary;
        }
    }
    internal class Manager : Employee
    {
        public string designation = "Manager";
        public double increment = .15;
        public override double get_salary()
        {
            int days = (DateTime.Now - date_of_joining).Days;
            int years = days / 365;
            return salary + salary * increment * years;
        }
    }
    internal class Salesperson : Employee
    {
        public string designation = "Salesperson";
        public double increment = .10;
        public override double get_salary()
        {
            int days = (DateTime.Now - date_of_joining).Days;
            int years = days / 365;
            return salary + salary * increment * years;
        }
    }
    internal class Typewriter : Employee
    {
        public string designation = "Typewriter";
        public double increment = .05;
        public override double get_salary()
        {
            int days = (DateTime.Now - date_of_joining).Days;
            int years = days / 365;
            return salary + salary * increment * years;
        }
    }
}
