using OOP_Principles.Abstraction;
using OOP_Principles.Inheritance;

void AbstractionClient()
{
    BadEmailService badEmailService = new BadEmailService();
    badEmailService.Connect();
    badEmailService.Authenticate();
    badEmailService.SendEmail("Please provide me access to the students panel.");
    badEmailService.Disconnect();

    Console.WriteLine("-------");


    // Abstraction
    EmailService emailService = new EmailService();
    emailService.SendEmail("Please provide me access to the students panel.");


}

void InheritanceClient()
{
    // Create instances
    Vehicle genericVehicle = new Vehicle("Generic", "V100", 2020);
    Car myCar = new Car("Toyota", "Camry", 2022, 4, "Gasoline");
    Bike myBike = new Bike("Trek", "FX2", 2021, "Hybrid", true);


    // Demonstrate behaviors
    Console.WriteLine("--- Generic Vehicle ---");
    genericVehicle.DisplayInfo();
    genericVehicle.Accelerate(20);
    genericVehicle.Brake(5);

    Console.WriteLine("\n--- Car ---");
    myCar.DisplayInfo();        // Calls Car's DisplayInfo()
    myCar.Accelerate(20);
    myCar.Brake(5);
    myCar.Honk();

    Console.WriteLine("\n--- Bike ---");
    myBike.DisplayInfo();       // Calls Bike's DisplayInfo()
    myBike.Accelerate(20);
    myBike.Brake(5);
    myBike.RingBell();


    // Base class
    Console.WriteLine("\n-------------");
    Vehicle car = new Car("Nissan", "Sunny", 2025, 4, "Gasoline");
    car.DisplayInfo();  // Calls Vehicle's DisplayInfo()
}



