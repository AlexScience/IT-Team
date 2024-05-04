namespace IT_Team;

public class Employee
{
    public string Name { get; init; }
    public Level Level { get; set; }

    public Employee()
    {
    }
    public Employee(string name,Level level)
    {
        Name = name;
        Level = level;
    }
}