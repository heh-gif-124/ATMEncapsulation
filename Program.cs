using System.Reflection.Metadata.Ecma335;
BankAccount bankAccount = new BankAccount("112233");
bool repeat = true;
while (repeat)
{
    Console.WriteLine("Welcome to THE EVIL Moklet ATM");
    Console.WriteLine("Menu");
    Console.WriteLine("1. Display info\n2. Draw Money\n3. Deposit Money\n4. Exit");
    string input = Console.ReadLine();
    switch (input){
        case "1":
            bankAccount.DisplayInfo();
            break;
        case "2":
            Console.WriteLine("Input the money: ");
            double amount = double.Parse(Console.ReadLine());
            bankAccount.Draw(amount);
            break;
        case "3":
            Console.WriteLine("Input the money: ");
            double amount2 = double.Parse(Console.ReadLine());
            bankAccount.Deposit(amount2);
            break;
        case "4":
            repeat = false;
            break;
        default:
            Console.WriteLine("Thats not an option, silly :3c");
            break;
    }
}
class BankAccount
{
    private double _Balance;

    private string _AccountNumber;

    public double Balance
    {
        get {  return _Balance; }
        set
        {
            if (value < 0) Console.WriteLine("Your balance canot be negative!");
        }
    }

    public string AccountNumber
    {
        get { return _AccountNumber; }
    }

    public BankAccount(string accountNumber)
    {
        _AccountNumber = accountNumber;
        _Balance = 1000000;
    }

    public void Draw(double amount)
    {
        if (amount > _Balance) Console.WriteLine("The amount should not exceed your balance!");
        else
        {
            _Balance -= amount;
            Console.WriteLine($"Successful, current balance: Rp {_Balance}");
        }


    }
    public void Deposit(double amount)
    {
        if (amount < 0) Console.WriteLine("The amount should not be negative!");
        else
        {
            _Balance += amount;
            Console.WriteLine($"Successful, current balance: Rp {_Balance}");
        }


    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account number/Balance:{AccountNumber}:{Balance}");
    }
}