# Exp03-Constructor
## Aim: 
To write a C# program to calculate the salary of an employee by passing the name, designation, noofexperience, basic salary and insurance amount through constructor.

## Algorithm:
### Step1:
The program starts by prompting the user to input various details of the employee, such as name, designation, years of experience, basic salary, and insurance amount. It uses Console.ReadLine() to read input from the user.

### Step2:
After the user enters the employee details, the program creates an Employee object by passing these details to the constructor. The Employee class encapsulates the properties and methods related to an employee, such as name, designation, years of experience, basic salary, and insurance amount.

### Step3:
The program then calls the DisplayDetails() method of the Employee class to display the entered employee details. This method prints out the employee's name, designation, years of experience, basic salary, and insurance amount.

### Step4:
After displaying the employee details, the program calculates the gross pay for the employee.It calls the CalculateGrossPay() method of the Employee class to perform this calculation. This method calculates the gross pay based on the provided information (basic salary, insurance amount, HRA and TA).

### Step5:
Once the gross pay is calculated, the program displays it to the user. It uses Console.WriteLine() to print out the calculated gross pay in currency format.

### Step6:
After displaying the gross pay, the program execution terminates, and the user is returned to the command line or console prompt.

## Program:
```C#
using System;

class Employee
{
    string name;
    string designation;
    int noOfExperience;
    float basicSalary;
    float insuranceAmount, hra, ta, grosspay;

    public Employee(string name, string designation, int noOfExperience, float basicSalary, float insuranceAmount)
    {
        this.name = name;
        this.designation = designation;
        this.noOfExperience = noOfExperience;
        this.basicSalary = basicSalary;
        this.insuranceAmount = insuranceAmount;
    }

    public void CalculateSalary()
    {
        hra = (20.0f / 100) * basicSalary;
        ta = (10.0f / 100) * basicSalary;
        grosspay = basicSalary + hra + ta - insuranceAmount;
    }

    public void DisplaySalary()
    {
        CalculateSalary(); // Call CalculateSalary() to calculate grosspay before displaying
        Console.WriteLine($"Employee Name: {name}");
        Console.WriteLine($"Designation: {designation}");
        Console.WriteLine($"No. of Experience: {noOfExperience} years");
        Console.WriteLine($"Basic Salary: {basicSalary:C}");
        Console.WriteLine($"Insurance Amount: {insuranceAmount:C}");
        Console.WriteLine($"Calculated Salary: {grosspay:C}");
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
        float basicSalary = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Insurance Amount:");
        float insuranceAmount = float.Parse(Console.ReadLine());

        Employee employee = new Employee(name, designation, noOfExperience, basicSalary, insuranceAmount);

        employee.DisplaySalary();
    }
}
```

## Output:
![output](<Screenshot 2024-03-03 090120.png>)

## Result:
Thus the above C# program to calculate the salary of an employee by passing the name, designation, noofexperience, basic salary and insurance amount through constructor is successfully executed
