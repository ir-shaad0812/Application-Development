namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicsStore store = new ElectronicsStore();
            Laptop l1 = new Laptop("Dell", 1200);
            Smartphone s1 = new Smartphone("Samsung", 800);
            store.AddDevice(l1);
            store.AddDevice(s1);
            store.ShowAllDeviceDetails();
        }
    }
    }

