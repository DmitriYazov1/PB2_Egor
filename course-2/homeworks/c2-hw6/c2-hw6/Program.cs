class Transport
{
    public string Model { get; set; }
    protected int Speed = 0;

    public void ShowInfo()
    {
        Console.WriteLine($"Модель: {Model}, скорость: {Speed} км/ч");

    }


    public virtual void Move()
    {
        Console.WriteLine("Транспорт движется");
    }
}

class Car : Transport
{
    public void Accelerate(int value)
    {
        if (value + Speed <= 200 && 0 <= value + Speed)
        {
            Speed += value;
        }
    }
    override public void  Move()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

class Bicycle: Transport
{
    public void Pedal()
    {
        Speed += 5;
    }

    override public void Move()
    {
        Console.WriteLine("Велосипед крутит педали");
    }
}





class Account
{
    private decimal balance;
    public string Owner { get; set; }


    public decimal Balance { get { return balance; } }

    public void Deposit(decimal amount)
    {
        if (amount >= 0)
        {
            balance += amount;
        }
    }
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Баланс: {Balance} руб.");
    }

}


class SavingsAccount : Account
{
    private decimal interestRate;

    public SavingsAccount(string owner, decimal rate)
    {
        Owner= owner;
        interestRate = rate;

    }

    public void AddInterest()
    {
        Deposit(Balance * (interestRate / 100));
    }
}