// Task 2: Inheritance 
public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {Brand}, Speed: {Speed}, Seats: {Seats}");
    }
}
