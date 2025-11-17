using System.Net.Cache;

class Person
{
    private int age;
    private string name;

    public int Age
    {
        get { return age; }

        set
        {
            if (value < 0)
            {
                age = value; 
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        
    }

    public string Name
    {
        get { return name; }

        set
        {
            if (value !="")
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }

}

class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && balance>=amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine(balance);
    }

}

class Thermometer
{
    private decimal temperatureCelsius;
    public decimal TemperatureCelsius {
        get { return temperatureCelsius; }
        set { if (value >= -273)
            {
                temperatureCelsius = value;
            } 
        }
    } 

    public decimal TemperatureFahrenheit
    {
        get { return (temperatureCelsius * 9 / 5) + 32; }

    }
}

class Animal
{
    protected int energy = 100;

    public void Eat()
    {
        energy += 10;
    }
}

class Dog : Animal
{
    public void Run()
    {
        energy -=20;
    }
}