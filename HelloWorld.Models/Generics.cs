namespace HelloWorld.Models
{
    public static class Generics<T> where T : Employee
    {
        public static void PrintSalary<Y>(T a , Y b) where Y : class
        {
            Console.WriteLine(a.FirstName);
        }
    }
}
