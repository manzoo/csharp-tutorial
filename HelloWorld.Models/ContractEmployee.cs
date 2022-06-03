namespace HelloWorld.Models
{
    public class ContractEmployee : Employee
    {
        public int HourlySalary { get; set; }

        public int TotalHours { get; set; }

        public override decimal CalculateSalary()
        {
            return HourlySalary * TotalHours;
        }
    }
}
