// See https://aka.ms/new-console-template for more information
using SoftwareArchitecture_OOP_REVISION;

Employee newEmployee = new Employee();

newEmployee.EmployeeId = 1;
newEmployee.EmployeeName = "Adi Maaita";
newEmployee.EmployeeDateOfBirth = DateTime.Now;
newEmployee.DaysOffAvailable = 14;
Console.WriteLine(newEmployee.EmployeeReport());

Console.WriteLine();

Employee newEmployee1 = new Employee(2, "Ahmad", DateTime.Now, 20);
Console.WriteLine(newEmployee1.EmployeeReport());

Manager mgr = new Manager();

