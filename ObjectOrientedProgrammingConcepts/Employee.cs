namespace ObjectOrientedProgrammingConcepts;

public class Employee : Person
{
    public string EmployeeCode { get; set; }
    public Employee(string firstName, string lastName, string employeeCode) : base(firstName, lastName)
    {
        EmployeeCode = employeeCode;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Employee Code: {EmployeeCode}");
    }
}
