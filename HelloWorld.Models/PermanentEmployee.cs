namespace HelloWorld.Models
{
    public class PermanentEmployee : Employee, IPerson, IAnimal
    {
        public int AnnualSalary { get; set; }

        public override decimal CalculateSalary()
        {
            return AnnualSalary / 12;
        }

        void IPerson.Eat()
        {
            Console.WriteLine($" as a person {FirstName} is eating");
        }

        void IAnimal.Eat()
        {
            Console.WriteLine($" as a animal {FirstName} is eating");
        }

        public void Walk()
        {
            Console.WriteLine($"{FirstName} is walking");
        }
    }
}
