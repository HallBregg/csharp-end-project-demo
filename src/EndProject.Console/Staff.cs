namespace EndProject.Console;

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
}

public class Manager : Staff
{
    public Manager(string name, float rate) : base(name, rate) {}
}


public class Admin : Staff
{
    public Admin(string name, float rate) : base(name, rate) {}
}