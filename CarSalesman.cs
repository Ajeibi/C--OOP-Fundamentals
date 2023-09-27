using System;

public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        this.Engage();
        this.EstablishTrust();
        this.AddressConcerns();
        this.DemoValue();
        this.Close();
    }

    protected override void Engage()
    {
        Console.WriteLine("Hello!");
    }

    protected override void EstablishTrust()
    {
        Console.WriteLine("I just want to quickly help you.");
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Everything is discounted");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this car!");
    }
}