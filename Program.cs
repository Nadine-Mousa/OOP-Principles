using OOP_Principles.Abstraction;
using OOP_Principles.Inheritance;
using OOP_Principles.Polymorphism;

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




// Without Polymorphism

List<object> objects = new List<object>();
objects.Add(new Animal("Animal", 2));
objects.Add(new Cat("Sally", 1));
objects.Add(new Dog("Husky", 3));

foreach (var _obj in objects)
{
    // Problem
    //_obj.Eat();         // gives an error
    //_obj.MakeSound();   // gives an error
    
    // Solution
    if(_obj is Cat)
    {
        var cat = (Cat)_obj;
        cat.Eat();
        cat.MakeSound();
    }
    else if(_obj is Dog)
    {
        var dog = (Dog)_obj;
        dog.Eat();
        dog.MakeSound();
    }
    // else if ...
    // you have to continue modifying this class whenever you add a new class
    // and this violates open-closed principle
    Console.WriteLine("----");
}

Console.WriteLine("\n\n\n");


// With Polymorphism => treating objects the same way

List<Animal> animals = new List<Animal>();
animals.Add(new Cat("Sally", 1));
animals.Add(new Dog("Husky", 3));

foreach (var animal in animals)
{
    animal.Eat();
    animal.MakeSound();
    Console.WriteLine("----");
}
