namespace HelloWorld.Models
{
    public class Person
    {
        public string? Name { get; set; }
        internal DateTime DOB { get; set; }

        protected internal string PAN {get; set;}

        private int Age { get; set; }

        private int _aadharNumber;

        protected bool IsHealthy { get; set; }

        public Person()
        {

            DOB = DateTime.UtcNow;
            Age = DOB.Year - DateTime.UtcNow.Year ;
            Name = "Deafult Name";
            IsHealthy = true;


            Console.WriteLine("Constructor called");
        }

        protected int GetAadharNumber()
        {
            // validate
            return _aadharNumber;

        }

        public Person(string name , int age)
        {
            Name = name;   
            Age = age;
        }

        public void Talk()
        {
            var dateOfBirth= DateTime.Now;
            Age = 75;
            IsHealthy = Age <= 60;
            var health = IsHealthy ? "Healthy" : "Sick";
            Console.WriteLine($"I am {health}");
            Console.WriteLine($"Hi ! I am {Name}. Aged about {Age}");
        }

        void Walk()
        {
            Console.WriteLine($"{Name} is walking");

        }


        private class Human
        {

        }


        

    }

}
