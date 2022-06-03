namespace HelloWorld.Models
{
    public class HandicappedPerson : Person
    {
        public void Walk()
        {
            IsHealthy = false;
            Console.WriteLine("I am a handicap person hence can't walk");
        }

    }

}
