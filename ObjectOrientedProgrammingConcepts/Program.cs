using ObjectOrientedProgrammingConcepts;

Console.WriteLine("Abstraction: Don't need to know the underlying detail to use it.");
Car c = new Car();
c.Accelerate();

Console.WriteLine($"{Environment.NewLine}*************{Environment.NewLine}");

Console.WriteLine("Encapsulation: Control access to methods/fields so that they cannot be accessed in unintended ways");
Account a = new Account("p");
Console.WriteLine($"Login Successful: {a.Login("a")}");
Console.WriteLine($"Login Successful: {a.Login("p")}");
Console.WriteLine($"Login Successful: {a.Login("a")}");
Console.WriteLine($"Login Successful: {a.Login("a")}");
Console.WriteLine($"Login Successful: {a.Login("a")}");
// a._failedLoginAttempts = 0;
Console.WriteLine($"Login Successful: {a.Login("p")}");

Console.WriteLine($"{Environment.NewLine}*************{Environment.NewLine}");

Console.WriteLine("Inheritance: child classes inherit behaviour and properties from their parent classes.");
Person p = new Person("Normal", "Person");
p.GetInfo();

Employee e = new Employee("Employee", "Person", "EP01");
e.GetInfo();

Console.WriteLine($"{Environment.NewLine}*************{Environment.NewLine}");

Console.WriteLine("Polymorphism: where you can have different implementations of methods called depending on what implementation of the expected type is provided");
IList<Person> people = new List<Person>();
people.Add(p);
people.Add(e);
foreach(Person person in people)
{
    person.GetInfo();
}