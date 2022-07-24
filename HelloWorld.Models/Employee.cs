namespace HelloWorld.Models
{
    public abstract  class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public abstract decimal CalculateSalary();

        public abstract void MarkAttendance();
        /*{
            Console.WriteLine($"{Id} : {FirstName} is present");
        }*/

        public void DistributeIdCard(int cardNumber, string cardType)
        {
            Console.WriteLine($"{Id} : {FirstName} is distributed");
        }


        public void DistributeIdCard()
        {
            Console.WriteLine($"{Id} : {FirstName} is distributed");
        }

        public void DistributeIdCard(string cardType, int cardNumber)
        {
            Console.WriteLine($"{Id} : {FirstName} with type {cardType} is distribute");
        }
    }
}
