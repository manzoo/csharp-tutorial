// See https://aka.ms/new-console-template for more information
using LINQ;

Console.WriteLine("Hello, World!");

var employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, FirstName = "Rajah", LastName = "Pruitt", Gender = 'M', Age = 28, IsActive = true },
            new Employee { EmployeeId = 2, FirstName = "Jane", LastName = "Trujillo", Gender = 'F', Age = 31, IsActive = true },
            new Employee { EmployeeId = 3, FirstName = "Grace", LastName = "Dejesus", Gender = 'F', Age = 36, IsActive = true },
            new Employee { EmployeeId = 4, FirstName = "Uriah", LastName = "Cole", Gender = 'M', Age = 26, IsActive = true },
            new Employee { EmployeeId = 5, FirstName = "Clare", LastName = "Melendez", Gender = 'M', Age = 41, IsActive = true },
            new Employee { EmployeeId = 6, FirstName = "Julian", LastName = "Byrd", Gender = 'F', Age = 38, IsActive = false },
            new Employee { EmployeeId = 7, FirstName = "Clark", LastName = "Conrad", Gender = 'M', Age = 53, IsActive = true },
            new Employee { EmployeeId = 8, FirstName = "Erich", LastName = "Booker", Gender = 'M', Age = 41, IsActive = true },
            new Employee { EmployeeId = 9, FirstName = "Minerva", LastName = "Walker", Gender = 'M', Age = 35, IsActive = false },
            new Employee { EmployeeId = 10, FirstName = "Leroy", LastName = "Blackwell", Gender = 'F', Age = 29, IsActive = true }
        };

var projects = new List<Project>
        {
            new Project { ProjectId = 1, PojectName = "Company Citadel", TotalDuration = 381 },
            new Project { ProjectId = 2, PojectName = "Apollo Research", TotalDuration = 104 },
            new Project { ProjectId = 3, PojectName = "Earth Surface Temperature Visualization", TotalDuration = 538 },
            new Project { ProjectId = 4, PojectName = "Uber's pickup analysis", TotalDuration = 252 },
        };

var employeeProjects = new List<EmployeeProject>
        {
            new EmployeeProject { EmployeeId = 1, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 2, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 4, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 5, ProjectId = 3 },
            new EmployeeProject { EmployeeId = 6, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 7, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 8, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 9, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 10, ProjectId = 3 },
            new EmployeeProject { EmployeeId = 6, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 1, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 9, ProjectId = 1 },
            new EmployeeProject { EmployeeId = 5, ProjectId = 2 },
            new EmployeeProject { EmployeeId = 3, ProjectId = 4 },
            new EmployeeProject { EmployeeId = 8, ProjectId = 3 },
            new EmployeeProject { EmployeeId = 7, ProjectId = 3 }
        };

var noOfProjects = 0;
foreach (var item in employeeProjects)
{

    if(item.EmployeeId == 5)
    {
        noOfProjects++;
    }
}

//Console.WriteLine($"No of project employee 1 has worked on is : {noOfProjects}");

// from VariableName in DataSOurce where condition select yourobject

var agedEmployees = from employee in employees
                    where employee.Age >=40
                    select new AnanymousType { FirstName = employee.FirstName , Age = employee.Age, EmployeeId = employee.EmployeeId};



var agedEmployeesNew = employees.Where(a => a.Age >= 41)
    .Select(employee => new AnanymousType { FirstName = employee.FirstName, Age = employee.Age, EmployeeId = employee.EmployeeId });


var agedEmployeesWithNameStartWithC = from emp in agedEmployees
                                      where emp.FirstName.StartsWith("c", true, System.Globalization.CultureInfo.InvariantCulture)
                                      select emp;


foreach (var item in agedEmployeesWithNameStartWithC)
{
    Console.WriteLine($" {item.FirstName} age is {item.Age} ");
}


var femaleEmployees = from employee in employees
                      where employee.Gender == 'F'
                      select employee.FirstName;

Console.WriteLine("Female employees");
foreach (var item in femaleEmployees)
{
    Console.WriteLine(item);
}


var aciveEmployees = from employee in employees
                     where employee.IsActive
                     select employee.FirstName;

Console.WriteLine("Active employees **********");
foreach (var item in aciveEmployees)
{
    Console.WriteLine(item);
}


var orderedEmployees = from employee in employees
                       orderby employee.Age
                       select employee;


Console.WriteLine("Ordered employees **********");
foreach (var item in orderedEmployees)
{
    Console.WriteLine(item.FirstName);
}
