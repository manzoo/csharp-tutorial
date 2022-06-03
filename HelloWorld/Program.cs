// See https://aka.ms/new-console-template for more information
using HelloWorld.Models;


var employees = new List<Employee>
{
    new PermanentEmployee { Id = 1, FirstName = "Manju", LastName ="A R", AnnualSalary = 12000},
    new ContractEmployee { Id = 2, FirstName = "Akshay", LastName ="M S", HourlySalary = 1200, TotalHours = 25},
    new PermanentEmployee { Id = 3, FirstName = "Bhavish", LastName ="S", AnnualSalary = 20000},
    new ContractEmployee { Id = 4, FirstName = "Praneeth", LastName ="A R",  HourlySalary = 1200, TotalHours = 25},
};


foreach (var employee in employees)
{
    //Console.WriteLine($"{employee.Id} : {employee.FirstName} salary is '{employee.CalculateSalary()}'");
}

IPerson newEmployee = new PermanentEmployee { Id = 1, FirstName = "Manju", LastName = "A R", AnnualSalary = 12000 };
newEmployee.Walk();
newEmployee.Eat();

IAnimal newEmployee1 = new PermanentEmployee { Id = 1, FirstName = "Praneeth", LastName = "A R", AnnualSalary = 12000 };
//newEmployee1.Walk();
newEmployee1.Eat();

