using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{

    public interface ISalaryCalculator
    {
        double CalculateSalary();
    }

    //Enum to select employee roles

    public enum EmployeeRole
    {
        Manager, 
        Developer,
        Designer
    }

    public delegate void EmployeeEventHandler(string message);


    public class Employee:ISalaryCalculator
    {
        //Fields
        private string name;
        private int age;
        private double salary;
        private int employeeid;


        //Event

        //public event EmployeeEventHandler OnPromotion;

        //Properties
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public double Salary { get { return salary; } set { salary = value; } }

        public int EmployeeID { get { return employeeid; } set { employeeid = value; } }

        //Constructors

        public Employee(string name, int age, double salary, int employeeid)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.employeeid= employeeid;
        }

        //parameterless Constructors
        public Employee() { }


        



        ~Employee()
        {

            //Destructors in C# are methods inside the class
            //used to destroy instances of that class when they are no longer needed

            Console.WriteLine($"Destructor: Employee {name} destroyed");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
        }

        // Method to calculate salary (from ISalaryCalculator interface)
        public double CalculateSalary()
        {
            // Sample salary calculation logic
            return salary * 12; // Assuming monthly salary, calculate annual salary
        }

        public void Promote(EmployeeRole newRole)
        {
            Console.WriteLine($"Employee {name} promoted to {newRole}");

            //OnPromotion?.Invoke($"Employee {name} promoted to {newRole}");
        }

        // Method to promote employee and invoke event
       


    }

   

   

}
