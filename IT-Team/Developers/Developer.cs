namespace IT_Team.Developers;

public class Developer : Employee
{
    public string Specialty { get; set; }

    public Developer(string name, Level level, string specialty) : base(name, level)
    {
        Specialty = specialty;
    }
}