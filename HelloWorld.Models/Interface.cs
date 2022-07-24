namespace HelloWorld.Models
{
    public  interface IFlyable
    {
        void Fly();
    }

    public interface IWalkable
    {
        void Walk();
    }





    public class Bird : IFlyable, IWalkable
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Walk()
        {
            Console.WriteLine("Bird is walking");
        }

        public void Eat()
        {

        }

        public void MakeSound()
        {

        }

    }

    public class Flight : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flight is flying");
        }
    }

}
