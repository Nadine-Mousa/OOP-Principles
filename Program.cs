using OOP_Principles.Abstraction;



BadEmailService badEmailService = new BadEmailService();
badEmailService.Connect();
badEmailService.Authenticate();
badEmailService.SendEmail("Please provide me access to the students panel.");
badEmailService.Disconnect();

Console.WriteLine("-------");


// Abstraction
EmailService emailService = new EmailService();
emailService.SendEmail("Please provide me access to the students panel.");


