namespace IT_Team;

public abstract record Employee
{
    public string Name { get; init; }
    
    protected  Employee(string name)
    {
        Name = name;
       
    }
}