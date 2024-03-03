using System;

class Employee
{
    string name;
    string designation;
    int noOfExperience;
    float basicSalary;
    float insuranceAmount,hra,ta,grosspay;

    public Employee(string name, string designation, int noOfExperience, float basicSalary, float insuranceAmount)
    {
        this.name = name;
        this.designation = designation;
        this.noOfExperience = noOfExperience;
        this.basicSalary = basicSalary;
        this.insuranceAmount = insuranceAmount;
    }

    public double CalculateSalary()
    {
        hra=(20)/100*basicSalary;
        ta=(10)/100*basicSalary;
        grosspay=basicSalary+hra+ta-insuranceAmount;
    }

    public void DisplaySalary()
    {
        Console.WriteLine($"Employee Name: {name}");
        Console.WriteLine($"Designation: {designation}");
        Console.WriteLine($"No. of Experience: {noOfExperience} years");
        Console.WriteLine($"Basic Salary: {basicSalary:C}");
        Console.WriteLine($"Insurance Amount: {insuranceAmount:C}");
        Console.WriteLine($"Calculated Salary: {CalculateSalary():C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Employee Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Designation:");
        string designation = Console.ReadLine();

        Console.WriteLine("Enter No. of Years Experience:");
        int noOfExperience = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Basic Salary:");
        double basicSalary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Insurance Amount:");
        double insuranceAmount = double.Parse(Console.ReadLine());

        Employee employee = new Employee(name, designation, noOfExperience, basicSalary, insuranceAmount);

        employee.DisplaySalary();
    }
}
