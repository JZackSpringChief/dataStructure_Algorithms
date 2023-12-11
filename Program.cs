Human human = new("Natasha", 31, true);
Human human1 = new("Kyle", 31, true);
Console.WriteLine($"Name: {human.Name} Age: {human.Age} In School: {human.InSchool}");
Console.WriteLine($"Name: {human1.Name} Age: {human1.Age} In School: {human1.InSchool}");
human.Negotiate();
human1.Hakkai();
public class Human
{
    public Human(string name, int age, bool inschool)
    {
        Name = name;
        Age = age;
        InSchool = inschool;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool InSchool { get; set; }
    public void Negotiate()
    {
        Console.WriteLine("Time to negotiate!");
    }
    public void Hakkai()
    {
        Console.WriteLine("Destroy!!!");
    }
}

public class Employee : Human
{
    public Employee(string name, int age, bool inschool) : base(name, age, inschool)
    {
    }
    public static void GetWage()
    {

    }
}