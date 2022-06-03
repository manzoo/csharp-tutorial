using HelloWorld.Models;

namespace HelloWorld
{
    public class VIP : Person
    {

        public void Print()
        {
            IsHealthy = true;
            PAN = "";
            Console.WriteLine("I am VIP person");
        }
    }
}
