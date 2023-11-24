// See https://aka.ms/new-console-template for more information
namespace EmployeeManagement.Employees;

public class Program
{

    public static void Main(string[] args)
    {

        Employee em1 = new Employee("Bamidele Fathia", 25, 150000.55, 101);
        Employee em2 = new Employee("Opeyemi Coker", 26, 155000.65, 102);
        Employee em3 = new Employee("Tolu Bashir", 35, 180000.75, 103);
        Employee em4 = new Employee("Adeola Seun", 47, 200000.15, 104);
        Employee em5 = new Employee("Simi Adele", 54, 120000.35, 105);
        Employee em6 = new Employee("Bola Segun", 34, 250000.45, 106);
        Employee em7 = new Employee("Hamid Jamiu", 27, 130000.15, 107);
        Employee em8 = new Employee("Olakunle Joseph", 28, 160000.05, 108);
        Employee em9 = new Employee("Peter Adetola", 33, 140000.55, 109);
        Employee em10 = new Employee("Collins ikechukwu", 32, 333000.55, 110);

        //Display employee Information
        Console.WriteLine("First Employee Information:");
        em1.DisplayInfo();
        Console.WriteLine("Second  Employee Information:");
        em2.DisplayInfo();
        Console.WriteLine("Third Employee Information:");
        em3.DisplayInfo();

        //Update Employee Information

        em1.Name = "Jane Doe";
        em1.EmployeeID = 113;
        em1.Salary = 120000.33;

        // Display updated information
        Console.WriteLine("\nUpdated Employee Information:");
        em1.DisplayInfo();

        // Calculate and display annual salary using interface method
        double annualSalary = em1.CalculateSalary();
        Console.WriteLine($"\nAnnual Salary: {annualSalary}");

     
        
        em1.Promote(EmployeeRole.Manager);

       
        Console.WriteLine("\nEnd of program");


       

    }




}
