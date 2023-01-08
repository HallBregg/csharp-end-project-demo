namespace EndProject.Console;

using System;

public abstract class Staff
{
    private float _rate;
    private int _workedHours;
    public int WorkedHours { get => _workedHours; set => _workedHours = value < 0 ? 0 : value; }
    public float TotalPay {protected set; get; }
    public float BasicPay { private set; get; }
    public string NameOfStaff { private set; get; }

    public Staff(string name, float rate)
    {
        NameOfStaff = name;
        _rate = rate;
    }

    public virtual void CalculatePay()
    {
        Console.WriteLine("Calculating Pay...");
        TotalPay = BasicPay = _workedHours * _rate;
    }

    public override string ToString()
    {
        return $"Name: {NameOfStaff}\nWorker Hours: {WorkedHours}\nBasic Pay: {BasicPay}\nTotal Pay: {TotalPay}";
    }
}

public class Manager : Staff
{
    private const float _managerRate = 50;
    public int Allowance { get; private set; }

    public Manager(string name) : base(name, _managerRate){}

    public override void CalculatePay()
    {
        base.CalculatePay();
        Allowance = 1000;
        if (WorkedHours > 160)
        {
            TotalPay += Allowance;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nAllowance: {Allowance}";
    }
}

public class Admin : Staff
{
    public Admin(string name, float rate) : base(name, rate) {}
}
