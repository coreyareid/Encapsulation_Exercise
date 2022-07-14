using Encapsulation_Exercise;

BankAccount account = new BankAccount();



Console.WriteLine("How much would you like to deposit?");
var amountToDeposit = double.Parse(Console.ReadLine());

account.Deposit(amountToDeposit);

Console.WriteLine($"Thanks you! Your balance is now {account.GetBalance()}");

Console.WriteLine("\nHow much would you like to withdraw?");


var amountToWithdraw = double.Parse(Console.ReadLine());
account.Withdraw(amountToWithdraw);

Console.WriteLine($"Thanks you! Your balance is now {account.GetBalance()}");