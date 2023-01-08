namespace EndProject.Test;

using EndProject.Console;
public class TestManager
{
    [Test]
    public void TestConstructor()
    {
        Manager manager = new Manager(name: "TestName");
        Assert.That(manager.NameOfStaff, Is.EqualTo("TestName"));
    }

    [Test]
    public void TestWorkerHoursSetterValidValue()
    {
        Manager manager = new Manager(name: "TestName");
        manager.WorkedHours = 160;
        Assert.That(manager.WorkedHours, Is.EqualTo(160));
    }

    [Test]
    public void TestWorkerHoursSetterInvalidValue()
    {
        Manager manager = new Manager(name: "TestName");
        manager.WorkedHours = -1;
        Assert.That(manager.WorkedHours, Is.EqualTo(0));
    }

    [Test]
    public void TestCalculateStandardPay()
    {
        Manager manager = new Manager(name: "TestName");
        manager.WorkedHours = 160;
        manager.CalculatePay();
        Assert.That(manager.TotalPay, Is.EqualTo(8000));
        Assert.That(manager.BasicPay, Is.EqualTo(8000));
    }

    [Test]
    public void TestCalculateExtraPay()
    {
        Manager manager = new Manager(name: "TestName");
        manager.WorkedHours = 161;
        manager.CalculatePay();
        Assert.That(manager.TotalPay, Is.EqualTo(9050));
        Assert.That(manager.BasicPay, Is.EqualTo(8050));
    }
}
