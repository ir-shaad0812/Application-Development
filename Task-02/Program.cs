class Program
{
   static void Main(string[] args)
   {
       Car car = new Car()
       {
           Brand = "Toyota",
           Speed = 180,
           Seats = 5
       };

       Motorcycle bike = new Motorcycle()
       {
           Brand = "Honda",
           Speed = 120,
           HasCarrier = true
       };

       Console.WriteLine("\n--- Car Info ---");
       car.Start();
       car.DisplayInfo();
       car.Stop();

       Console.WriteLine("\n--- Motorcycle Info ---");
       bike.Start();
       bike.DisplayInfo();
       bike.Stop();
   }
}
