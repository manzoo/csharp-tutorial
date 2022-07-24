namespace HelloWorld.Models
{
    public  class Converter
    {

        public static int MyProperty { get; set; }

        public static decimal ConvertMeterToFeet(decimal meter)
        {
            return meter * (decimal)3.2;
        }   
        
        public void Convert()
        {
            MyProperty = 10;

            var meter = ConvertMeterToFeet(MyProperty);
        }

        public static IFlyable GetFlyable()
        {
            return new Flight();
        }
    }

}
