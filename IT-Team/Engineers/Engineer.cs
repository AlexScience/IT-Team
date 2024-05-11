namespace IT_Team.Engineers;

public abstract record Engineer : Employee
{
    public Level Level { get; set; }

    protected Engineer(string name,Level level) : base(name)
    {
        Level = level;
    }
}