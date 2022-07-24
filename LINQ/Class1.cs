using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }

    class AnanymousType
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }

    class Project
    {
        public int ProjectId { get; set; }
        public string PojectName { get; set; }
        public int TotalDuration { get; set; }
    }

    class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
    }


}
