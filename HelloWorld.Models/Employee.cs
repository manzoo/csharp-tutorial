namespace HelloWorld.Models
{
    public abstract  class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public abstract decimal CalculateSalary();

        public void MarkAttendance()
        {
            Console.WriteLine($"{Id} : {FirstName} is present");
        }

        public void DistributeIdCard()
        {
            Console.WriteLine($"{Id} : {FirstName} is present");
        }
    }
}
