namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Make = "GMC";
            car1.Model = "YukonXL";
            car1.Year = 2021;

            Console.WriteLine($" The vehicle is a {car1.Year} {car1.Make} {car1.Model}.");
        }
    }
}
