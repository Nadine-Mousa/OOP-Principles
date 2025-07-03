using OOP_Principles.Encapsulation;




BankAccount mohamedBankAccount = new BankAccount(100);

mohamedBankAccount.Deposit(20);
Console.WriteLine(mohamedBankAccount.GetBalance());

mohamedBankAccount.Deposit(100);
Console.WriteLine(mohamedBankAccount.GetBalance());

mohamedBankAccount.Withdraw(50);
Console.WriteLine(mohamedBankAccount.GetBalance());

