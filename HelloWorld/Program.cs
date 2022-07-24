// See https://aka.ms/new-console-template for more information
using HelloWorld.Models;
using System.Collections.Generic;

Employee emp = new PermanentEmployee();
emp.CalculateSalary();
emp = new ContractEmployee();


var parsedValue = int.Parse("10");


var meter = 10;
Converter.MyProperty = 10;
var feet = Converter.ConvertMeterToFeet(meter);

//InternEmployee internEmployee = new PermanentEmployee();

var employees = new List<Employee>
{
    new PermanentEmployee { Id = 1, FirstName = "Manju", LastName ="A R", AnnualSalary = 12000},
    new ContractEmployee { Id = 2, FirstName = "Akshay", LastName ="M S", HourlySalary = 1200, TotalHours = 25},
    new PermanentEmployee { Id = 3, FirstName = "Bhavish", LastName ="S", AnnualSalary = 20000},
    new ContractEmployee { Id = 4, FirstName = "Praneeth", LastName ="A R",  HourlySalary = 1200, TotalHours = 25},
};


foreach (var employee in employees)
{
    //employee.MarkAttendance();
    employee.DistributeIdCard("Plastic", 10);
    employee.DistributeIdCard(10, "Smart");
    Console.WriteLine(employee.GetType().Name);
    Console.WriteLine($"{employee.Id} : {employee.FirstName} salary is '{employee.CalculateSalary()}'");

    //Generics.PrintSalary(employee);
}


var flyble = Converter.GetFlyable();

flyble.Fly();


var partial = new PartialClass();
partial.Method1();
partial.Method2();
partial.Method3();
partial.Method4();



var array = new int[]{1, 2,3,4};

array[0] = 4;
array[3] = 6;



var list = new List<int> { 1, 2, 3, 5};
list.Add(10);
list.Add(89);
list.Remove(10);

var list1 = new List<int>();
var list2 = new List<int>();

foreach (var item in list1)
{
    Console.WriteLine(item);

}

list1.AddRange(list2);

list.Insert(10, 67);
list.InsertRange(15, new[] { 1, 2, 3 });

var dict = new Dictionary<int, Employee>
{
    { 1, new PermanentEmployee() { Id = 1, FirstName = "manju"} }
};

dict.Add(10, new PermanentEmployee());

dict.Add(15, new PermanentEmployee());

dict.Remove(15);
Console.WriteLine( dict.Count);



var l = new LinkedList<int>();


if (dict.ContainsKey(15))
{
    var employee = dict[15];
}

foreach (var item in dict)
{
    Console.WriteLine($" {item.Key}, {item.Value}");
}


















/*
IPerson newEmployee = new PermanentEmployee { Id = 1, FirstName = "Manju", LastName = "A R", AnnualSalary = 12000 };
newEmployee.Walk();
newEmployee.Eat();

IAnimal newEmployee1 = new PermanentEmployee { Id = 1, FirstName = "Praneeth", LastName = "A R", AnnualSalary = 12000 };
//newEmployee1.Walk();
newEmployee1.Eat();
*/
